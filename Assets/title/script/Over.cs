using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;
//using TMPro;
//using System;

public class Over : MonoBehaviour
{
    //public InputActionReference _action;
    //private InputAction _input;
    // Start is called before the first frame update
    //Vector2 x = new Vector2(0, 0.0583f);
    private bool flag1;
    public TMP_Text _Text1;
    public TMP_Text _Text2;
    //SpriteRenderer sr;
    public GameObject Wall;private informertion _in;
    public GameObject game;
    //public InputActionReference _ref;
    //private InputAction _action;
    private void Awake()
    {
        _Text2.color = new Color(255,255,255,0);
    }
    void Start()
    {
        //_Text2.color = new Color(255,255,255,0);
        //_action = _ref.action;
       //sr = _Text1.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.anyKeyDown && flag1 == false)
        {
            Debug.Log("push");
            flag1 = true;
            StartCoroutine(waitOne());
        }

    }
    IEnumerator waitOne()
    {
        int i = 0;
        while (i < 120)
        {
            gameObject.transform.position += new Vector3(0,0.0583f/2,0);
            yield return null;
            i++;
        }

        yield return new WaitForSeconds(1);

        

        _in = Wall.GetComponent<informertion>();
        _Text1.text = "Your Score " + _in.str;
        float ii = 0;
        while (ii <= 1) 
        {
            //Debug.Log("ii="+ii);
            _Text1.color = new Color(255,255,255,ii);
            yield return null;
            ii+= 0.005f;
            //if (ii == 1) _end();
        }
            //yield return new WaitForSeconds(2);

            float iii = 0;
            
            _Text2.text = "Thank you for playing!";
            _Text2.rectTransform.anchoredPosition = new Vector3(0, -2, 0);
            while (iii <= 1)
            {
                _Text2.color = new Color(255, 255, 255, iii);
                yield return null;
                iii += 0.005f;
                //Debug.Log(_Text2);
            }
        yield return new WaitForSeconds(1);
        if (Input.anyKeyDown)
        {
           SceneManager.LoadSceneAsync("title");
        }
        else
        {
            yield return null;
        }

    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (!other.gameObject.CompareTag("_gameOver"))
        {
            other.gameObject.SetActive(false);
            game.SetActive(false);
        }
    }


}
