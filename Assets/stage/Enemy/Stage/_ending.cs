using System.Collections;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class _ending : informertion
{
    public TMP_Text[] _text;
    private int newScoa;
    private float x = 0; 
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < _text.Count(); i++)
        {
            _text[i].color = new Color(255, 255, 255, 0);
        }
        _text[0].text = "Clear!";
        _text[1].text = "Your Score "+str;
        _text[2].text = "Bom=500";
        _text[3].text = "player=1000";

        newScoa = scoa + _nokoriB * 500 + _zan * 1000;

        //_text[1].text = newScoa.ToString();

        _text[4].text = "Thank you for playng!";
        StartCoroutine(main());
    }

    // Update is called once per frame
    /*void Update()
    {
        //x += 0.01f;
        /*
        _text[0].color = new Color(255,255,255,x);
        if(x > 1)
        {
            _text[1].color = new Color(255,255,255,x - 1);
        }
        if(x > 2)
        {
            _text[2].color = new Color(255, 255, 255, x - 2);
            _text[3].color = new Color(255, 255, 255, x - 2);
        }
        if(x > 4)
        {
            _text[1].text = "Your Score " + newScoa.ToString();
        }
        if(x > 6)
        {
            _text[4].color = new Color(255, 255, 255, x - 6);
        }
        if(x > 7 && Input.anyKeyDown)
        {
            StartCoroutine(enumerator());
        }
    }
    IEnumerator enumerator()
    {
        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync("title");
        while (!asyncLoad.isDone)
        {
            yield return null;
        }
    }*/
    IEnumerator main()
    {
        while (x < 1)
        {
            x += 0.01f;
            _text[0].color = new Color(255, 255, 255, x);
            yield return null;
        }

        yield return new WaitForSeconds(1);

        while (x < 2)
        {
            x += 0.01f;
            _text[1].color = new Color(255, 255, 255, x - 1);
            yield return null;
        }

        yield return new WaitForSeconds(1);

        while (x < 3)
        {
            x += 0.01f;
            _text[2].color = new Color(255, 255, 255, x - 2);
            _text[3].color = new Color(255, 255, 255, x - 2);
            yield return null;
        }

        yield return new WaitForSeconds(1);

        while (x < 5)
        {
            x += 0.01f;
            _text[1].text = "Your Score " + newScoa.ToString();
            yield return null;
        }

        yield return new WaitForSeconds(1);

        while (x < 7)
        {
            x += 0.01f;
            _text[4].color = new Color(255, 255, 255, x - 6);
            yield return null;
        }
        while (x < 8)
        {
            if (Input.anyKeyDown)
            {
                AsyncOperation asyncLoad = SceneManager.LoadSceneAsync("title");
                while (!asyncLoad.isDone)
                {
                    yield return null;
                }
            }
            yield return null;
        }
    }
}
