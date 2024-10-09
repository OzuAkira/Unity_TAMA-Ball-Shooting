using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class M_BossBullet : MonoBehaviour
{
    public GameObject mainBullet;
    private float timer = 0;
    private int frame = 0;
    public float H = 0.0f;
    public float H2 = 0.0f;
    private Vector3 bulletpoint_1;
    private Vector3 bulletpoint_2;
    private Vector3 bulletpoint_3;
    private Vector3 bulletpoint_4;
    
    // Start is called before the first frame update
    void Start()
    {
        H = Random.Range(-2.5f,-1.25f);
        H2 = Random.Range(1.25f,2.5f);
        bulletpoint_1 = new Vector3(H,2,0);
        bulletpoint_2 = new Vector3(H2,2,0);
        H = Random.Range(-1.25f,0);
        H2 = Random.Range(0,1.25f);
        bulletpoint_3 = new Vector3(H,2,0);
        bulletpoint_4 = new Vector3(H2,2,0);
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        frame++;
        if(timer >= 3 && timer >= 4)
        {
            Instantiate(mainBullet,bulletpoint_1,Quaternion.identity);
            Instantiate(mainBullet,bulletpoint_2,Quaternion.identity);
            Instantiate(mainBullet,bulletpoint_3,Quaternion.identity);
            Instantiate(mainBullet,bulletpoint_4,Quaternion.identity);
            timer = 3;
        }
        if(frame%60 == 0)
        {
         H = Random.Range(-2.5f,-1.25f);
        H2 = Random.Range(1.25f,2.5f);
        bulletpoint_1 = new Vector3(H,2,0);
        bulletpoint_2 = new Vector3(H2,2,0);
        H = Random.Range(-1.25f,0);
        H2 = Random.Range(0,1.25f);
        bulletpoint_3 = new Vector3(H,2,0);
        bulletpoint_4 = new Vector3(H2,2,0);
    
        }
        
    }
}
