using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading.Tasks;
using Unity.VisualScripting;
using UnityEngine.SceneManagement;
//using TMPro.EditorUtilities;
using TMPro;
using System.Linq;

public class EnemyCreate : MonoBehaviour
{
    private float timeCount = 0;

    public GameObject fEnemy;
    Vector2 first = new Vector2(-2.7f, 4);
    private bool flag1 = false;

    public GameObject sEnemy;
    Vector2 second = new Vector2(2.7f, 3);
    private bool flag2 = false;

    public GameObject srdEnemy;
    Vector2 serd_1 = new Vector2(-1.5f, 5);
    Vector2 serd_2 = new Vector2(1.5f, 5);
    private bool flag3 = false;

    public GameObject srdEnemy_C;
    Vector2 serd_3 = new Vector2(0, 5);
    private bool flag4 = false;

    public GameObject M_Boss;
    private bool flag5 = false;
    //private int M_count = 0;
    private bool flag6 = false;
    private bool flag7 = false;
    private bool flag8 = false;
    //II_flag II;
    Vector2 M = new Vector2(0, 7.3f);
    flagOnly E_Flag = null;
    GameObject CreateEnemy;
    EnemyBasic D_flag;
    private bool flag9 = false;
    private bool flag10 = false;
    public GameObject leftEnemy;
    public GameObject rightEnemy;
    public GameObject downEnemy;
    public GameObject upEnemy;
    private bool flag11 = false;
    private bool flag12 = false;
    public GameObject StageBoss;
    private bool flag13 = false;
    public GameObject BomEnemy;
    private bool flag14 = false;
    private bool flag15 = false;
    private GameObject b;
    public GameObject wall; informertion _informertion;
    public GameObject mask; SpriteRenderer sr;
    public TMP_Text[] _text;
    private int newScoa;
    private float x = 0;
    public GameObject player;
    CircleCollider2D cc;
    //public GameObject 

    // Start is called before the first frame update
    void Start()
    {
        _informertion = wall.GetComponent<informertion>();
        sr = mask.GetComponent<SpriteRenderer>();
        sr.color = new Color(0,0,0,0);
        mask.SetActive(false);
        _source = GetComponent<AudioSource>();
        // Clear.SetActive(false);


        for (int i = 0; i < _text.Count(); i++)
        {
            _text[i].color = new Color(255, 255, 255, 0);
        }
        _text[0].text = "Clear!";
        //_text[1].text = "Your Score " + _informertion.str;
        _text[2].text = "Bom=1000";
        _text[3].text = "player=3000";

       // newScoa = _informertion.scoa + _informertion._nokoriB * 500 + _informertion._zan * 1000;

        //_text[1].text = newScoa.ToString();

        _text[4].text = "Thank you for playng!";
    }

    // Update is called once per frame
    void Update()
    {
        timeCount += Time.deltaTime;
        if (timeCount > 5 && flag1 == false)
        {
            flag1 = true;
            delay_right();
        }
        if (timeCount > 7 && flag2 == false)
        {
            flag2 = true;
            delay_left();
        }
        if (timeCount > 10 && flag3 == false)
        {
            flag3 = true;
            flag6 = Instantiate(srdEnemy, serd_1, Quaternion.identity);
            //II = CreateEnemy.GetComponent<II_flag>();
            //flag6 = II.flaG;
            Instantiate(srdEnemy, serd_2, Quaternion.identity);
            //II = CreateEnemy.GetComponent<II_flag>();
            //flag7 = II.flaG;
            timeCount = 0;
        }
        if (timeCount > 10 && flag6 == true && flag4 == false)
        {
            flag4 = true;
            CreateEnemy = Instantiate(srdEnemy_C, serd_3, Quaternion.identity);
            E_Flag = CreateEnemy.GetComponent<flagOnly>();
            flag8 = true;
        }
        if (flag8) {
            if (E_Flag.threeEnemys && flag5 == false)
            {
                flag5 = true;
                CreateEnemy = Instantiate(M_Boss, M, Quaternion.identity);
                D_flag = CreateEnemy.GetComponent<EnemyBasic>();
            }
        }
        //flagOnly M = srdEnemy_C.GetComponent<flagOnly>();
        //Debug.Log("Create" + M.threeEnemys);
        if (flag5)
        {
            if (D_flag.die)
            {
                if (flag7 == false)
                {
                    flag7 = true;
                    timeCount = 0;
                }
                if (timeCount > 2 && flag7)
                {
                    if (flag9 == false)
                    {
                        flag9 = true;
                        delay_right2();
                    }
                    if (timeCount > 1.5f && flag10 == false)
                    {
                        flag10 = true;
                        delay_left2();
                    }
                    if (timeCount > 3 && flag11 == false)
                    {
                        flag11 = true;
                        delay_down();
                    }
                    if (timeCount > 3 && flag12 == false)
                    {
                        flag12 = true;
                        delay_up();
                        timeCount = 0;
                    }
                }
            }
            if (timeCount >= 15 && flag12 && flag14 == false)
            {
                flag14 = true;
                Instantiate(BomEnemy, serd_3, Quaternion.identity);

            }
            if (flag12 && timeCount >= 23 && flag13 == false)
            {
                b = Instantiate(StageBoss, new Vector3(0, 6.3f, 0), Quaternion.identity);

                flag13 = true;
            }
            /*  if (flag13)
              {
                  BL = StageBoss.GetComponent<BossLief>();
              }*/
            if (b != null)
            {
                if (b.activeSelf == false && flag15 == false)
                {
                    flag15 = true;
                    cc = player.GetComponent<CircleCollider2D>();
                    cc.enabled = false;
                    mask.SetActive(true);
                    baria.SetActive(true);
                    _informertion = wall.GetComponent<informertion>();
                    _text[1].text = "Your Score " + _informertion.str;
                    newScoa = _informertion.scoa + _informertion._nokoriB * 1000 + _informertion._zan * 3000;
                    StartCoroutine(kuria());
                }
            }
        }
        //Debug.Log(b.activeSelf);

    }
    public GameObject baria;
    public AudioClip[] audios;
    private AudioSource _source;
    IEnumerator kuria()
    {
        
        while (x < 1)
        {
            x += 0.01f;
            sr.color = new Color(sr.color.r, sr.color.g, sr.color.b, x);
            yield return null;
        }

        x = 0;

        yield return new WaitForSeconds(2);

        _source.clip = audios[2];
        _source.Play();

        while (x < 1)
        {
            _text[0].color = new Color(255, 255, 255, x);
            yield return null;
            x += 0.01f;
        }

        yield return new WaitForSeconds(1);

        _source.clip = audios[0];
        _source.Play();

        while (x < 2)
        {
            x += 0.01f;
            _text[1].color = new Color(255, 255, 255, x - 1);
            yield return null;
        }

        yield return new WaitForSeconds(1);

        _source.clip = audios[0];
        _source.Play();

        while (x < 3)
        {
            x += 0.01f;
            _text[2].color = new Color(255, 255, 255, x - 2);
            _text[3].color = new Color(255, 255, 255, x - 2);
            yield return null;
        }

        yield return new WaitForSeconds(1);

        _source.clip = audios[1];
        _source.Play();

        while (x < 5)
        {
            x += 0.01f;
            _text[1].text = "Your Score " + newScoa.ToString();
            yield return null;
        }

        yield return new WaitForSeconds(1);

        _source.clip = audios[0];
        _source.Play();

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

    /*yield return new WaitForSeconds(2);
    AsyncOperation asyncLoad = SceneManager.LoadSceneAsync("Crea");

    // ���[�h���܂��Ȃ玟�̃t���[����
    while (!asyncLoad.isDone)
    {
        yield return null;
    }*/


    async void delay_right()
    {
        for(int i=0;i<5;i++)
            {
                Instantiate(fEnemy,first,Quaternion.identity);
                await Task.Delay(500); 
            }
    }
    async void delay_left()
    {
        for(int i=0;i<5;i++)
            {
                Instantiate(sEnemy,second,Quaternion.identity);
                await Task.Delay(500);    
            }
    }
    async void delay_right2()
    {
        for(int i=0;i<30;i++)
            {
                Instantiate(rightEnemy,first,Quaternion.identity);
                await Task.Delay(500); 
            }
    }
    async void delay_left2()
    {
        for(int i=0;i<27;i++)
            {
                Instantiate(leftEnemy,new Vector3(3.5f,-3.5f),Quaternion.identity);
                await Task.Delay(500); 
            }
    }
    async void delay_down()
    {
        for(int i=0;i<24;i++)
            {
                Instantiate(downEnemy,new Vector3(2.2f,5.6f),Quaternion.identity);
                await Task.Delay(500); 
            }
    }
    async void delay_up()
    {
        for(int i=0;i<21;i++)
            {
                Instantiate(upEnemy,new Vector3(-2.2f,-5.6f),Quaternion.identity);
                await Task.Delay(500); 
            }
    }




}
