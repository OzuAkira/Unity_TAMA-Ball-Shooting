using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Down : MonoBehaviour
{
    public GameObject game;
    private bool f;
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
       
        if(gameObject.transform.position.y <= 10.5f && f == false)
        {
            Debug.Log(gameObject.transform.position);
            f = true;
            Instantiate(game,new Vector3(0,40,0),Quaternion.identity);
            Destroy(gameObject,6000);
        }
        gameObject.transform.position -= new Vector3(0,0.01f,0);
    }
}
