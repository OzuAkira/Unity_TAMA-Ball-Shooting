using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBasic : MonoBehaviour
{
    public int Enemy_HP = 1;
    public bool die = false;
    informertion _informertion;
    private GameObject _gameObject;

    public AudioClip[] audios;
    private AudioSource _source;
    // Start is called before the first frame update
    void Start()
    {
        _gameObject = GameObject.Find("R_wall");
        if (_gameObject == null) return;
        _informertion = _gameObject.GetComponent<informertion>();
        _source = GetComponent<AudioSource>();
        
    }

    void OnTriggerEnter2D(Collider2D players)
    {
        if(players.gameObject.CompareTag("Player_bullet"))
        {
            Enemy_HP--;
            _source.clip = audios[0];
            _source.Play();
            _informertion.scoa++;
            Destroy(players.gameObject);
            if(Enemy_HP <= 0)
            {
                _informertion.scoa+=100;
                _source.clip = audios[1];
                _source.Play();
                Destroy(gameObject,0.1f);
                die = true;
            }

        }
    }
}
