using UnityEngine;
using UnityEngine.InputSystem;

public class ButtonHold : MonoBehaviour
{
    // Input Actionを参照する変数
    public InputActionReference _button;
    private InputAction buttonAction;
    void Awake()
    {
        buttonAction = _button.action;
    }

    // 長押しとみなす時間
    //public float holdDuration = 1.0f;

    // 内部状態
    //private float holdTime = 0.0f;
    public int isHolding = 0;

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

    void Update()
    {
        // ボタンが押されている場合、時間をカウント
        if (isHolding > 0)
        {
            //Debug.Log("Button held long enough!");
                // 長押し処理をここで実行
                
                // 一度長押しが認識されたらリセット
                //holdTime = 0.0f;
                //isHolding = false;
            
        }
    }

    // ボタンが押されたときに呼ばれる
    private void OnButtonPressed(InputAction.CallbackContext context)
    {
        isHolding++;
        //holdTime = 0.0f;
    }

    // ボタンが離されたときに呼ばれる
    private void OnButtonReleased(InputAction.CallbackContext context)
    {
        isHolding = 0;
        //holdTime = 0.0f;
    }
}