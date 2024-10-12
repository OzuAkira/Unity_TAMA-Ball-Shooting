using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.InputSystem;
using System;
public abstract class carsol : MonoBehaviour
{
    public Sprite OffSprite;
    public Sprite OnSprite;

    // 画像描画用のコンポーネント
    SpriteRenderer spriteRenderer;
    public abstract void Select();

    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
    }

    // カーソルが合っているとき
    public void On()
    {
        // 画像を切り替える
        spriteRenderer.sprite = OnSprite;
        if(spriteRenderer != null )return;
        //Debug.Log("teisoku=");
    }
    // カーソルが合っていないとき
    public void Off()
    {
        // 画像を切り替える
        spriteRenderer.sprite = OffSprite;
    }

/*

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
        RefreshDisplay();
    }

    private void OnDestroy() {
        CleanUpOperation();
    }
    public virtual void StartRebinding()
    {
        if(_action == null)return;
        _redindOperation?.Cancel();



        _action.Disable();
        var bindingIndex = _action.GetBindingIndex(
            InputBinding.MaskByGroup(_scheme)
        );
        
        if(_mask != null)_mask.SetActive(true);

        void OnFinished()
        {
            CleanUpOperation();
            _action.Enable();
            if(_mask != null)_mask.SetActive(false);
        }
        _redindOperation = _action
            .PerformInteractiveRebinding(bindingIndex)
            .OnComplete(_ =>
            {
                RefreshDisplay();
                OnFinished();
            })
            .OnCancel(_ =>
            {
                OnFinished();
            })
            .Start();

    }



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
*/
    }
