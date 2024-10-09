using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dropItam : MonoBehaviour
{    
    public GameObject dropItem;
    private bool Flag = true;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        EnemyBasic HP = gameObject.GetComponent<EnemyBasic>();
        if(HP.Enemy_HP <= 0 && Flag)
        {
            Flag = false;
            Instantiate(dropItem,gameObject.transform.position,Quaternion.identity);
        }
    }
}
