using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kago : MonoBehaviour
{
    private float timer =0;
    private GameObject playerObj;
    public GameObject bulletObj;
    
    private int count = 0;
    private float firsttime = 18;
    private float endtime = 33.5f;
    private float changeX = 0;
    //private bool oneF = false;
    private bool forsCount = false;
    public float speed = 0.1f;
    private bool X = true;
    private Vector2 target;
    // Start is called before the first frame update
    void Start()
    {
        playerObj = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        count++;
        timer += Time.deltaTime;
        if(changeX < 1 && forsCount == false)
        {
            changeX += Time.deltaTime/2 ;
        }
        else
        {
            forsCount = true;
            changeX -= Time.deltaTime/2;
        }
        if(changeX <= -1){forsCount = false;}

        if(playerObj == null)
        {
            target = new Vector2(0,-3);
        }
        if(timer >= firsttime && X)
        {
            playerObj = GameObject.Find("Player");
            X = false;
            if(playerObj == null)return;
            target = playerObj.transform.position;
        }
        if(timer >= firsttime && count%3 == 0 )
        {
            var bullet = Instantiate(bulletObj,gameObject.transform.position,Quaternion.identity);
            Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
            rb.velocity = new Vector2(target.x + 1.5f + changeX,target.y);
             bullet = Instantiate(bulletObj,gameObject.transform.position,Quaternion.identity);
            rb = bullet.GetComponent<Rigidbody2D>();
            rb.velocity = new Vector2(target.x - 1.5f + changeX,target.y);
        }
        if(timer >= endtime )
        {
            timer = 0;
            endtime = 27.5f;
            firsttime = 12;
            X = true;
        }
    }

}
