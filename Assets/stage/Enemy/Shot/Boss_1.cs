using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.VersionControl;
using UnityEngine;

public class Boss_1 : MonoBehaviour
{
    private float timer = 0;
    private float angle = 0;
    //public GameObject  ;
    // Start is called before the first frame update

    void Start()
    {
        //public Vector3 taeget = Vector3.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if(timer >= 6 && timer <= 17)
        {
            angle = timer * 90;
            gameObject.transform.Rotate(0,0,angle);
        }
        if(timer >= 18 && timer <=29)
        {
            
        }
    }

    

}