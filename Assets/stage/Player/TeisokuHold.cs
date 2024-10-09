using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class TeisokuHold : MonoBehaviour
{
    public InputActionReference _teisoku;
    private InputAction buttonAction;
    public int teisokuHolding = 0;

    // Start is called before the first frame update
    void Awake()
    {
        buttonAction = _teisoku.action;
    }

    void OnEnable()
    {
        // Input Actionを有効化
        buttonAction.Enable();
        buttonAction.performed += OnButtonPressed;
        buttonAction.canceled += OnButtonReleased;
    }

    void OnDisable()
    {
        // Input Actionを無効化
        buttonAction.performed -= OnButtonPressed;
        buttonAction.canceled -= OnButtonReleased;
        buttonAction.Disable();
    }
    // ボタンが押されたときに呼ばれる
    private void OnButtonPressed(InputAction.CallbackContext context)
    {
        teisokuHolding++;
        //holdTime = 0.0f;
    }

    // ボタンが離されたときに呼ばれる
    private void OnButtonReleased(InputAction.CallbackContext context)
    {
        teisokuHolding = 0;
        //holdTime = 0.0f;
    }
}
    // Update is called once per frame


