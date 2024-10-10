using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
//using TMPro;
//using System;

public class Over : MonoBehaviour
{
    public InputActionReference _action;
    private InputAction _input;
    // Start is called before the first frame update
    void Start()
    {
        _input = _action.action;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

}
