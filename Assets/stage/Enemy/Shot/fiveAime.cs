using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading.Tasks;

public class fiveAime : MonoBehaviour
{
    private int time = 0;
    public float speed = 10;
    public GameObject Aim_E_bullet; 
    GameObject playerObj;
    private int count =0;
    private int X =12;



    void Start()
    {
        playerObj = GameObject.Find("Player");
        
    }

     void aimShot()
    {
        time++;
        if(playerObj == null){playerObj = GameObject.Find("Player");}
        else if(time%X == 0 ){
            count++;
            X = 12;
            var pos = gameObject.transform.position;
            var bullet = Instantiate(Aim_E_bullet);
            bullet.transform.position = pos;
            Vector2 vec = playerObj.transform.position - pos;
            Vector2 vec_1 = vec + new Vector2(1.5f,0);
            Vector2 vec_2 = vec + new Vector2(-1.5f,0);
            Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
            rb.velocity = vec * speed;
                bullet = Instantiate(Aim_E_bullet,gameObject.transform.position,Quaternion.identity);
            rb = bullet.GetComponent<Rigidbody2D>();
            rb.velocity = vec_1 * speed;
                bullet = Instantiate(Aim_E_bullet,gameObject.transform.position,Quaternion.identity);
            rb = bullet.GetComponent<Rigidbody2D>();
            rb.velocity = vec_2 * speed;
        }
        if(count>5){
            count = 0;
            time = 0;
            X = 120; 
        }
            //Instantiate(Aim_E_bullet,transform.position,Quaternion.identity);
            //Aim_E_bullet.transform.position = Vector3.MoveTowards(Aim_E_bullet.transform.position,playerObj.transform.position,Time.deltaTime);
    }

    // Update is called once per frame
    void Update()
    {
        aimShot();
    }
}
