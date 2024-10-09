using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class B_bullet1 : MonoBehaviour
{
    //private float timer = 0;
    private float speed = 0.05f;
    //public float aNgle = 30;
    // Start is called before the first frame update
    void Start()
    {
        gameObject.transform.Rotate(0,0,10);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Wall") || other.gameObject.CompareTag("bulia")){
            Destroy(gameObject,5.0f);
        }
    }
    // Update is called once per frame
    void Update()
    {
        /*timer += Time.deltaTime;
        if (timer >= 0.5f)
        {
            timer = 0;
            //aNgle = aNgle * -1;
            //gameObject.transform.localRotation = Quaternion.Euler(0,0,aNgle);
        }*/

        gameObject.transform.position -= transform.up * speed;
        
    }
}


