using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deliteBullet : MonoBehaviour
{
    private int frame = 0;
    // Start is called before the first frame update
    void Awake()
    {
        gameObject.SetActive(false);
    }
    private void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.gameObject.CompareTag("Enemy_bullet"))
        {
            Destroy(other.gameObject);
        }
    }
    private void Update()
    {
        frame++;
        if(frame > 240)
        {
            gameObject.SetActive(false);
            frame = 0;
        }
    }
}
