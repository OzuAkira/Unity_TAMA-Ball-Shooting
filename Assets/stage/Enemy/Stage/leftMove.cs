using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class leftMove : MonoBehaviour
{
    private float timer = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer++;
        gameObject.transform.position += Vector3.left * 0.03f; 
        if (timer > 300){
            gameObject.SetActive(false);
        }
    }
}
