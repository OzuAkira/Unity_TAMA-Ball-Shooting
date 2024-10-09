using UnityEngine;
using UnityEngine.InputSystem;

public class test : MonoBehaviour
{
    [SerializeField] private InputActionReference _actionRef;

    private void Awake()
    {
        gameObject.SetActive(false);
        if (_actionRef == null) return;

        _actionRef.action.performed += OnJump;

        _actionRef.action.Enable();
    }

    private void OnDestroy()
    {
        if (_actionRef == null) return;

        _actionRef.action.performed -= OnJump;
        _actionRef.action.Dispose();
    }

    private void OnJump(InputAction.CallbackContext obj)
    {
        print("Jump");
    }
}