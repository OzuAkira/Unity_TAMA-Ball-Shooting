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
    public GameObject _gameOver;
    SpriteRenderer sr;
    private float time = 0.0f;
    //private CircleCollider2D Cir_col;
    public bool dieFlag = false;
    private Vector2 res_position;
    public playerMove Z;
    float x = 0;
    private void Awake()
    {
        _gameOver.SetActive(false);
        
    }
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
            Z = player.GetComponent<playerMove>();
            if (Z.zan >= -1)
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
                   
                }
            }
            else
            {
            
                sr = _gameOver.GetComponent<SpriteRenderer>();
                sr.color = new Color(sr.color.r, sr.color.g, sr.color.b,0);
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
        //int i = 0;
        yield return new WaitForSeconds(2);
        _gameOver.SetActive(true);
        
        
        while (x < 100)
        {
            x += 0.005f;
            sr.color = new Color(sr.color.r, sr.color.g, sr.color.b,x);
            yield return null;
            Debug.Log(x);
        }
    }
    IEnumerator ranking()
    {
        yield return null;//new WaitForSeconds(1);
    }
}
