using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bom_ilas : MonoBehaviour
{
    SpriteRenderer sr;
    public GameObject _bom;
    public GameObject player;
    private bool f;
    /*private bool ff;
    private int x;
    private int y;*/
    // Start is called before the first frame update
     void Start()
    {
        sr = gameObject.GetComponent<SpriteRenderer>();
        sr.color = new Color(sr.color.r,sr.color.g,sr.color.b,0);
    }

    // Update is called once per frame
    void Update()
    {
        if(_bom.activeSelf == true && f == false)
        {
            f = true;
           // ff=false;
            gameObject.transform.position = player.transform.position;
            sr.color = new Color(sr.color.r,sr.color.g,sr.color.b,0.7f);

            //StartCoroutine(anime());
        }
        if(_bom.activeSelf == false)
        
            //ff = true;
            //f=true;
            
            sr.color = new Color(sr.color.r,sr.color.g,sr.color.b,0);
            f = false;
        }
    }
    
    
    
//}
