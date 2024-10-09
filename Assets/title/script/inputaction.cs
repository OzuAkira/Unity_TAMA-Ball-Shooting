using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class inputaction : MonoBehaviour
{
    public string _action;
    public GameObject carsol;
    private void Start() 
    {
        gameObject.SetActive(false);
    }

    void Update()
    {
        StartCoroutine(input());
         
    }
    IEnumerator input()
    {
        carsol.SetActive(false);
        
        /*

        if(Input.GetButtonDown("b"))
        {
            _action ="b";
            wait();
        }
        else if(Input.GetButtonDown("a"))
        {
            _action ="a";
            wait();
        }
        else if(Input.GetButtonDown("y"))
        {
            _action ="y";
            wait();
        }
        else if(Input.GetButtonDown("x"))
        {
            _action ="x";
            wait();
        }
        else if(Input.GetButtonDown("L"))
        {
            _action ="L";
            wait();
        }
        else if(Input.GetButtonDown("R"))
        {
            _action ="R";
            wait();
        }
        else*/ if(Input.GetKey(KeyCode.Escape))
        {
            _action =null;
            wait();
        }

        

        while(true)
        {
            Debug.Log("While実行中");
            yield return null;
        }
    }
    void wait()
    {
        //StopCoroutine(input());
        Debug.Log(_action);
        
        /*
        inputaction inputaction = new inputaction();
        config config = inputaction;
        */

        carsol.SetActive(true);
        gameObject.SetActive(false);
        //yield return new WaitForSeconds(1.0f);
    }
}
