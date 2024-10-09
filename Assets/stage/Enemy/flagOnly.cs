using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flagOnly : MonoBehaviour
{
    public bool threeEnemys = false;
    private bool M_flag = false;
    private float timeCount = 0;
    public GameObject M_B;
    private Vector2 serd_3 = new Vector2(0,7.3f);
    EnemyBasic HPscript;
    //private int count = 0;
    // Start is called before the first frame update
    void Start()
    {
        HPscript = gameObject.GetComponent<EnemyBasic>();
    }

    // Update is called once per frame
    void Update()
    {
         
        
        if(HPscript.Enemy_HP <= 0)
        {
            //Debug.Log(threeEnemys);
            threeEnemys = true;
        } 
        if(threeEnemys == true && M_flag == false)
        {
            //Debug.Log("three");
            timeCount += Time.deltaTime;
            M_flag = true;
        }
    }
}
