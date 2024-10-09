using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading.Tasks;
public class AimShot : MonoBehaviour
{
    // Start is called before the first frame update
private int time = 0;
private int rnd = 0;
public GameObject Aim_E_bullet; 
GameObject playerObj;




    void Start()
    {
        playerObj = GameObject.Find("Player");
        rnd = Random.Range(1,24);
        //Debug.Log(rnd);
        
    }

    void aimShot()
    {
        time++;
        if(playerObj == null){playerObj = GameObject.Find("Player");}
        else if(time == 2+rnd ){
            var pos = gameObject.transform.position;
            var bullet = Instantiate(Aim_E_bullet);
            bullet.transform.position = pos;
            Vector2 vec = playerObj.transform.position - pos;
            bullet.GetComponent<Rigidbody2D>().AddForce(vec * 10);
            //await Task.Delay(500);
            //Instantiate(Aim_E_bullet,transform.position,Quaternion.identity);
            //Aim_E_bullet.transform.position = Vector3.MoveTowards(Aim_E_bullet.transform.position,playerObj.transform.position,Time.deltaTime);
            
        }
    }

    // Update is called once per frame
    void Update()
    {
        aimShot();
    }
}
