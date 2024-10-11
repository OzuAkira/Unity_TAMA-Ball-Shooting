using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEditor.Callbacks;
using UnityEngine;
using UnityEngine.SceneManagement;

public class resurrection : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject player;
    public GameObject bulia;
    public GameObject Wall;
    public GameObject _gameOver;
    public GameObject _backG;
    SpriteRenderer sr;
    SpriteRenderer sr2;
    informertion _in;
    public TMP_Text _Text1;
    //public RectTransform _RectTransform;
    //public TMP_Text _Text2;
    private float time = 0.0f;
    //private CircleCollider2D Cir_col;
    public bool dieFlag = false;
    private Vector2 res_position;
    public playerMove Z;
    float x = 0;
    float y = 0;
    private bool f;
    private void Awake()
    {
        _gameOver.SetActive(false);
        _backG.SetActive(false);

        
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
                   
                }
            }
            else
            {
            
                

                
                //_Text2.color = new Color(_Text2.color.r,_Text2.color.g,_Text2.color.b,0);
                if (f == false)
                {
                    sr = _gameOver.GetComponent<SpriteRenderer>();
                    sr.color = new Color(sr.color.r, sr.color.g, sr.color.b,0);

                    sr2 = _backG.GetComponent<SpriteRenderer>();
                    sr2.color = new Color(0,0,0,0);

                    _Text1.color = new Color(_Text1.color.r,_Text1.color.g,_Text1.color.b,0);
                    StartCoroutine(otukare());
                    f = true;
                }
                //
            }
        }
        if(dieFlag == true)
        {
            time += Time.deltaTime;
            if (time > 4)
            {
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
        Debug.Log("gameover");
        yield return new WaitForSeconds(4);
        _gameOver.SetActive(true);
        _backG.SetActive(true);
        _Text1.rectTransform.anchoredPosition = new Vector3(0, 0, 0);

        while (x < 100)
        {
            x += 0.005f;
            sr.color = new Color(sr.color.r, sr.color.g, sr.color.b,x);
            sr2.color = new Color(0, 0, 0, x);
            yield return null;
            //Debug.Log(x);
        }
        //x = 0;
       /* while(x >= 100)
        {
            y += 0.005f;
            sr.color = new Color(sr.color.r, sr.color.g, sr.color.b,100);
            sr2.color = new Color(0, 0, 0,100);
           /* _Text1.color = new Color(250,250,250,y);
            if(y >= 100)
            {
                _in = Wall.GetComponent<informertion>();
                _Text1.text = "Your Score "+_in.str;
            }
           */
            yield return null;
        }
    }
    
    /*
    IEnumerator ranking()
    {
        int i = 0;
        while (i < 180)
        {
            _gameOver.transform.position += new Vector3(0,0.0583f/3,0);
            yield return null;
            i++;
        }
    }
    */

