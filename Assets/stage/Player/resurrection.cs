using System.Collections;
using System.Collections.Generic;
using UnityEditor.Callbacks;
using UnityEngine;
using UnityEngine.SceneManagement;

public class resurrection : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject player;
    public GameObject bulia;
    private float time = 0.0f;
    //private CircleCollider2D Cir_col;
    public bool dieFlag = false;
    private Vector2 res_position;
    public playerMove Z;
    void Start()
    {
        //Cir_col = player.GetComponent<CircleCollider2D>();
        bulia.SetActive(false);
        res_position = gameObject.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
         if (player.activeSelf == false )
         {
            if (Z.zan >= 0)
            {
                time += Time.deltaTime;
                player.transform.position = res_position;
                if (time > 3)
                {
                    player.SetActive(true);
                    bulia.SetActive(true);
                    //Cir_col.enabled = false;
                    dieFlag = true;
                    time = 0;
                    Z = player.GetComponent<playerMove>();
                }
            }
            else
            {
                StartCoroutine(otukare());
                Debug.Log("gameover");
            }
        }
        if(dieFlag == true)
        {
            time += Time.deltaTime;
            if (time > 4){
                    //Cir_col.enabled = true;
                    bulia.SetActive(false);
                    time = 0;
                    dieFlag = false;
            }
       }
    }
    IEnumerator otukare()
    {
        yield return new WaitForSeconds(2);
        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync("GameOver");

        // ロードがまだなら次のフレームへ
        while (!asyncLoad.isDone)
        {
            yield return null;
        }
    }
}
