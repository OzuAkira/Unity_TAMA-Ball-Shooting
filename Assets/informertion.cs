using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class informertion : MonoBehaviour
{
    [SerializeField] private TMP_Text _Text;
    [SerializeField] private TMP_Text _Text2;
    [SerializeField] private GameObject _mask;
    [SerializeField] private GameObject play;
    private EnemyBasic _HP;
    [SerializeField] private playerMove playerMove;

    public int scoa;
    public string str;
    Bom _bom;
    public int _nokoriB;
    public int _zan;
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
        _bom = play.GetComponent<Bom>();
        _nokoriB = _bom.nokoriBOM;


        str = scoa.ToString();
        _Text.text = str;
        _zan = playerMove.zan;

        string x =_zan.ToString();
        if(playerMove.zan > 0)_Text2.text = "Player "+x;
        else _Text2.text="Player 0";
    }
    //void
}
