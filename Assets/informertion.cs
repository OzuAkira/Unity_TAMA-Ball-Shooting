using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class informertion : MonoBehaviour
{
    public TMP_Text _Text;
    public GameObject _mask;
    private EnemyBasic _HP;
    public int scoa;
    // Start is called before the first frame update
    /*private void OnTriggerStay2D(Collider2D other) 
    {
        if(other.CompareTag("Enemy"))
        {
            _HP = other.GetComponent<EnemyBasic>();
            if(beforHP < _HP.Enemy_HP)
            {
                
            }
            beforHP = _HP.Enemy_HP;
        }

    }*/
    void Start()
    {
        
        //Debug.Log("�R�~�b�g�o���������H");
    }

    // Update is called once per frame
    void Update()
    {
        string str = scoa.ToString();
        _Text.text = str;
    }
}
