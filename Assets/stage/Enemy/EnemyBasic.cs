using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBasic : MonoBehaviour
{
    public int Enemy_HP = 1;
    public bool die = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnTriggerEnter2D(Collider2D players){
        if(players.gameObject.CompareTag("Player_bullet"))
        {
            Enemy_HP--;
            Destroy(players.gameObject);
            if(Enemy_HP <= 0){
                Destroy(gameObject,0.1f);
                die = true;
            }

        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
