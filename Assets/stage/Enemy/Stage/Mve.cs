using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mve : MonoBehaviour
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
        gameObject.transform.position += Vector3.right * 0.03f;
        if (timer > 300){
            gameObject.SetActive(false);
        }
    }
}
