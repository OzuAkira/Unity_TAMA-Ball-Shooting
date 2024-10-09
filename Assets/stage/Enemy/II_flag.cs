using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class II_flag : MonoBehaviour
{
    EnemyBasic HPscript;
    EnemyCreate A;
    public bool flaG;
    public int cOunt;
    //private int count = 0;
    // Start is called before the first frame update
    void Start()
    {
        HPscript = gameObject.GetComponent<EnemyBasic>();
        GameObject Air = GameObject.Find("AirObj");
        A = Air.GetComponent<EnemyCreate>();
    }

    // Update is called once per frame
    void Update()
    {if(HPscript.Enemy_HP <= 0)
        {
            //count++;

            //A. = false;
        }
        
    }
}
