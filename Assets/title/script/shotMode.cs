using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.InputSystem;
using System;

public class shotMode : carsol
{
    //public GameObject ipm;
    public imo rebindUI;
    /*private void Start()
    {
    rebindUI = gameObject.GetComponent<imo>();
    }*/
    
    public override void Select()
    {
        rebindUI = gameObject.GetComponent<imo>();
        //  ipm.SetActive(false);
        GetComponent<AudioSource>().Play();
        rebindUI.StartRebinding();
    }
}




/*
public class kari : MonoBehaviour
{
    private void Start()
    {
        imo2 imo2 = new imo2();
        shotMode shotMode = imo2();
    }
}
*/
