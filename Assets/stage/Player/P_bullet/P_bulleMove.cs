using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P_bulleMove : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 20.0f;

    void Start()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if(other.gameObject.CompareTag("Wall")){
            Destroy(gameObject,5);
        }
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0,speed * Time.deltaTime,0);
    }
}
