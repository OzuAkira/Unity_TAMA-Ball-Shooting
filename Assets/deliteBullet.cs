using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deliteBullet : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
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
}
