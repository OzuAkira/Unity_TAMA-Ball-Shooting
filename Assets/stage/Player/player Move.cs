using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class playerMove : MonoBehaviour
{
    // Start is called before the first frame update
    Vector3 _velocity;
    //private float _onteisoku = 0;
    GameObject resPos;
    float move_speed = 3.7f;
    TeisokuHold teisokuHold;
    /*

    string shot;
    string teisoku;
    public GameObject S_mask;
    public GameObject T_mask;
    public inputaction shotObj;
    public GameObject teisokuObj;

     */
    void Start()
    {
        resPos = GameObject.Find("Player_Resurrection");
        teisokuHold = gameObject.GetComponent<TeisokuHold>();
    //   shotObj = S_mask.GetComponent<inputaction>();
    //  shot = shotObj._action;
    }

    void OnMove(InputValue value)
    {
        var axis = value.Get<Vector2>();
        _velocity = new Vector2(axis.x,axis.y);
    }

    // Update is called once per frame
    
    /*void OnTeisoku(InputValue input)
    {

        //_onteisoku = input.isPressed;
        //Debug.Log("Onteisoku");
    }
    /*void OffTeisoku()
    {
        Debug.Log("offteisoku");
        _onteisoku = false;
    }*/

    private void OnTriggerEnter2D(Collider2D other) {
        //Debug.Log("coll");        
         if (other.gameObject.CompareTag("Enemy_bullet") || other.gameObject.CompareTag("Enemy")){
//            Debug.Log("bullet");
            resurrection script = resPos.GetComponent<resurrection>();
            if(script.dieFlag == false){
                gameObject.SetActive(false);
            }
        }
    }

    void Update()
    {
        if(teisokuHold.teisokuHolding > 0)
        {
            move_speed = 1.5f;
            //_onteisoku = false;
        }
        else
        {
            move_speed = 4f;
        }
       /*

        if ()
        {
            move_speed = 1.5f;
        }
        
        */
        Rigidbody2D rb = GetComponent<Rigidbody2D>();
        rb.velocity = _velocity * move_speed;
        if (gameObject.activeSelf == false){
            _velocity = new Vector2(0,0);
        }
    }
   /* public void move_lim(Vector2 input_velocity,float input_Mspeed){
        input_velocity = _velocity;
        input_Mspeed = move_speed;
    }*/
}
