using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBasic : MonoBehaviour
{
    public int Enemy_HP = 1;
    public bool die = false;
    informertion _informertion;
    private GameObject _gameObject;
    // Start is called before the first frame update
    void Start()
    {
        _gameObject = GameObject.Find("R_wall");
        _informertion = _gameObject.GetComponent<informertion>();
    }

    void OnTriggerEnter2D(Collider2D players)
    {
        if(players.gameObject.CompareTag("Player_bullet"))
        {
            Enemy_HP--;
            GetComponent<AudioSource>().Play();
            _informertion.scoa++;
            Destroy(players.gameObject);
            if(Enemy_HP <= 0)
            {
                _informertion.scoa+=100;
                GetComponent<AudioSource>().Play();
                Destroy(gameObject,0.1f);
                die = true;
            }

        }
    }
}
