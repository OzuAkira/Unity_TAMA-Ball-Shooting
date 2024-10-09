using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Itemfall : MonoBehaviour
{
    public int X = 1;
    // Start is called before the first frame update
    void Start()
    {
       gameObject.GetComponent<Rigidbody2D>().AddForce(Vector3.up * X);
    }

    private void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.gameObject.CompareTag("Player"))
        {
            Destroy(gameObject);

        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
