using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading.Tasks;

public class mBoss_LR : MonoBehaviour
{
    // Start is called before the first frame update
private int time = 0;
private int shotCount = 0;
private float T = 0;
public GameObject Aim_E_bullet; 
GameObject playerObj;




    void Start()
    {
        playerObj = GameObject.Find("Player");
        
    }

     void aimShot()
    {
        time++;
        if(playerObj == null){playerObj = GameObject.Find("Player");}
        else if(time > 180 && time%60 == 0){
            shotCount++;
            var pos = gameObject.transform.position;
            var bullet = Instantiate(Aim_E_bullet);
            bullet.transform.position = pos;
            Vector2 vec = playerObj.transform.position - pos;
            bullet.GetComponent<Rigidbody2D>().AddForce(vec * 30);
            //await Task.Delay(1000);

            //Instantiate(Aim_E_bullet,transform.position,Quaternion.identity);
            //Aim_E_bullet.transform.position = Vector3.MoveTowards(Aim_E_bullet.transform.position,playerObj.transform.position,Time.deltaTime);
            
        }
    }

    // Update is called once per frame
    void Update()
    {
        
        if(shotCount >= 4)
        {
            T += Time.deltaTime;
            if(T > 1)
            {
                shotCount = 0;
                T = 0;    
            }
            //await Task.Delay(3000);
        }
        else
        {
            aimShot();
        }
    }
}
