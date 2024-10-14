using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Power : MonoBehaviour
{
    public GameObject wall;
    informertion _info;
    public int P = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("Power"))
        {
            if(P < 2)
            {
                P++;
            }
            else
            {
                _info = wall.GetComponent<informertion>();
                _info.scoa += 500;
            }
        }
        
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
