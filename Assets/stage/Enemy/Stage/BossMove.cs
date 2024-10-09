using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossMove : MonoBehaviour
{
    private float A = 0;
    private float B = 60;
    //private int C = 0;
    private float Sin;
    private float Cos;
    private float timer;
    //Vector2 Obj;
    //private int f = 0;
    // Start is called before the first frame update
    void Start()
    {
         
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        //Debug.Log(timer);
        if(timer >= 6 && timer < 16.5)
        {
            Sin = Mathf.Sin(A);
            Cos = Mathf.Cos(B);
        
            A += 0.01f;
            B += 0.01f;
            gameObject.transform.position = new Vector3(Sin , 2.5f+Cos , 0);
        }
        if(timer >= 16.5 && timer < 17)
        {
            gameObject.transform.position = new Vector2(0,gameObject.transform.position.y);
            Sin = 0;
            Cos = 0;
            A = 0;
            B = 60;
        }
        if(timer >= 17 && timer < 27.5)
        {
            //Debug.Log("Chenge!");
            Sin = Mathf.Sin(A) * -1;
            Cos = Mathf.Cos(B);
        
            A += 0.01f;
            B += 0.01f;
            gameObject.transform.position = new Vector3(Sin ,2.25f + Cos, 0);
        }
        if(timer >= 27.5 && timer < 28)
        {
            gameObject.transform.position = new Vector2(0,1.5f);
            Sin = 0;
            Cos = 0;
            A = 0;
            B = 60;
            timer = 0;
        }
        
        //Debug.Log("Time="+timer);
    }
    
}
