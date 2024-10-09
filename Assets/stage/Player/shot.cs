using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class shot : MonoBehaviour
{
    
    private ButtonHold buttonHold;
    public float speed = 7.0f;
    public GameObject buletObj;
    private int shot_count = 0;
    Vector3 bulletPoint;
    //private int _onshot = 0;
    //private InputAction action;
    /*
    config config = new shot();
    shot shot = (shot)config2;
    */
    // Start is called before the first frame update
    void Start()
    {
        buttonHold = gameObject.GetComponent<ButtonHold>();
        Application.targetFrameRate = 60;
        bulletPoint = transform.Find("BulletPoint").localPosition;
        //_action = inputActions.action;
    }
    /*void OnEnable()
    {
        // Input Actionを有効化
        _action.Enable();
        _action.performed += OnShotStarted;
        _action.canceled += OnShotCanceled;
    }

    void OnDisable()
    {
        // Input Actionを無効化
        _action.performed -= OnShotStarted;
        _action.canceled -= OnShotCanceled;
        _action.Disable();
    }*/

    // Update is called once per frame
    void Update()
    {
        shot_count++;

        Power P_script = gameObject.GetComponent<Power>();
        if(/*Input.GetKey(KeyCode.Z) || _onshot > 0 */buttonHold.isHolding > 0 && shot_count%10 == 0){
            if(P_script.P < 2)
            {
                Instantiate(buletObj,transform.position + bulletPoint,Quaternion.identity);
            }
            if(P_script.P >= 2)
            {
                Instantiate(buletObj,transform.position + bulletPoint,Quaternion.Euler(0,0,2.5f));
                Instantiate(buletObj,transform.position + bulletPoint,Quaternion.Euler(0,0,-2.5f));
            }
            //_onshot = false;
        }
    }
    /*
    public void OnShotStarted(InputAction.CallbackContext context)
    {
        _onshot++;
    }
    public void OnShotCanceled(InputAction.CallbackContext context)
    {
        _onshot = 0;
    }
   /*
    void OnEnable()
    {
        action = inputActions.FindAction("Shot");

        action.Enable();
        action.performed  += OnShot;

        //_onshot = true;
        //Debug.Log("onshot");
    }
    void OnDisable()
    {
        action.Disable();
        action.performed -= OnShot;
    }
    private void OnShot(InputAction.CallbackContext context)
    {
        Debug.Log("ショット実行中");
    }*/
    
}

