using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
//using TMPro;
//using System;

public class Over : MonoBehaviour
{
    //public InputActionReference _action;
    //private InputAction _input;
    // Start is called before the first frame update
    //Vector2 x = new Vector2(0, 0.0583f);
    void Start()
    {
       // _input = _action.action;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.anyKeyDown)
        {
            Debug.Log("push");
            StartCoroutine(waitOne());
        }

    }
    IEnumerator waitOne()
    {
        int i = 0;
        while (i < 180)
        {
            gameObject.transform.position += new Vector3(0,0.0583f/3,0);
            yield return null;
            i++;
        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        other.gameObject.SetActive(false);
    }

}
