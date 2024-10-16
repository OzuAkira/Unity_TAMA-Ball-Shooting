using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Power : MonoBehaviour
{
    public GameObject wall;
    informertion _info;
    public int P = 0;
    public AudioClip[] audios;
    private AudioSource _source;
    // Start is called before the first frame update
    void Start()
    {
        _source = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("Power"))
        {
            if(P < 2)
            {
                _source = GetComponent<AudioSource>();
                _source.clip = audios[0];
                _source.Play();
                P++;
            }
            else
            {
                _source = GetComponent<AudioSource>();
                _source.clip = audios[1];
                _source.Play();
                _info = wall.GetComponent<informertion>();
                _info.scoa += 500;
            }
        }
        
    }
    // Update is called once per frame
    //
}
