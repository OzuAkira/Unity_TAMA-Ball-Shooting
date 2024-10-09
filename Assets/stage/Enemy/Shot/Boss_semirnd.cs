using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss_semirnd : MonoBehaviour
{
    private float timer = 0;
    //private float X = 1;
    public GameObject bulletObj;
    public int X;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer ++;
        //rnd();
        if(timer >= 360 && timer%120 == 0 && timer <= 60*17)
        {
           Instantiate(bulletObj,gameObject.transform.position,Quaternion.Euler(0,0,X));
        }
        if(timer >= 1650)
        {
            timer = 0;
        }
    }

}
