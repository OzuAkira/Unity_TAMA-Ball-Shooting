using UnityEngine;
using UnityEngine.InputSystem;

public class testscript : MonoBehaviour
{
    public InputActionReference actionReference;
    private InputAction buttonAction;

    void Start()
    {
        buttonAction = actionReference.action;
        Debug.Log("ButtonAction" + buttonAction);
    }
    void OnEnable()
    {
        // ボタンが押されたときにOnButtonPressedを呼ぶ
        buttonAction.performed += OnButtonPressed;
        buttonAction.Enable();
    }

    void OnDisable()
    {
        // リスナーを解除
        buttonAction.performed -= OnButtonPressed;
        buttonAction.Disable();
    }

    // ボタンが押されたときに呼ばれるメソッド
    private void OnButtonPressed(InputAction.CallbackContext context)
    {
        Debug.Log("Button was pressed!");
        // ここにボタンが押されたときの処理を追加
    }
}
