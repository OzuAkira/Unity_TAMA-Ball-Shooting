using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.InputSystem;
using System;

public class imo  : MonoBehaviour
{
    [SerializeField] private InputActionReference _actionref;
    [SerializeField] private string _scheme = "Gamepad";
    [SerializeField] private TMP_Text _pathText;
    [SerializeField] private GameObject _mask;
    private InputAction _action;

    private InputActionRebindingExtensions.RebindingOperation _redindOperation;
    private void  Awake()
    {
        if(_actionref == null) return;
        _action = _actionref.action;
        _mask.SetActive(false);
        RefreshDisplay();
    }

    private void OnDestroy() {
        CleanUpOperation();
    }
    public void StartRebinding()
    {
        if(_action == null)return;
        _redindOperation?.Cancel();



        _action.Disable();
        int bindingIndex = _action.GetBindingIndex(
            InputBinding.MaskByGroup(_scheme)
        );
        
        if(_mask != null)_mask.SetActive(true);

        void OnFinished()
        {
            CleanUpOperation();
            _action.Enable();
            if(_mask != null)_mask.SetActive(false);
        }
        //StartCoroutine(read());
        
        _redindOperation = _action
            .PerformInteractiveRebinding(bindingIndex)
            .OnComplete(_ =>
            {
                //Debug.Log("complete");
                RefreshDisplay();
                OnFinished();
            })
            .OnCancel(_ =>
            {
                //Debug.Log("cancel");
                OnFinished();
            }).Start();
        /*if(Input.GetKeyDown(KeyCode.Escape))
        {
            OnFinished();
        }*/
        

    }

    /*
    IEnumerator read()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            yield break;
        }
        else
         _redindOperation = _action
            .PerformInteractiveRebinding(bindingIndex)
            .OnComplete(_ =>
            {
                Debug.Log("complete");
                RefreshDisplay();
                OnFinished();
            })
            .OnCancel(_ =>
            {
                Debug.Log("cancel");
                OnFinished();
            }).Start();
    }
    */

    public void RefreshDisplay()
    {
        if(_action == null || _pathText == null) return;
        _pathText.text = _action.GetBindingDisplayString();
    }
    private void CleanUpOperation()
    {
        _redindOperation?.Dispose();
        _redindOperation = null;
    }
}
