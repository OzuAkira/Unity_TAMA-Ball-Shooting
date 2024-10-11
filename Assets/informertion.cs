using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class informertion : MonoBehaviour
{
    public TMP_Text _Text;
    public TMP_Text _Text2;
    public GameObject _mask;
    private EnemyBasic _HP;
    public playerMove playerMove;
    public int scoa;
    public string str;
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
        str = scoa.ToString();
        _Text.text = str;

        string x = playerMove.zan.ToString();
        if(playerMove.zan > 0)_Text2.text = "Player "+x;
        else _Text2.text="Player 0";
    }
}
