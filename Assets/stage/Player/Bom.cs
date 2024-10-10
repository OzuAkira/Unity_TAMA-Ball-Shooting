using System.Collections;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using UnityEngine;

public class Bom : MonoBehaviour
{
    public int nokoriBOM = 2;
    public TMP_Text _Text;
    private resurrection _resurrection;
    //public GameObject[] E_buret;
    public GameObject _BObj;
    
    void Start()
    {
        GameObject Res = GameObject.Find("Player_Resurrection");
        _resurrection = Res.GetComponent<resurrection>();
    }
    void OnBom()
    {
        if(nokoriBOM > 0)
        {
            nokoriBOM--;
            StartCoroutine(C_FireB());
            //Debug.Log("Fire!!");
        }
    }
    IEnumerator C_FireB()
    {
        _resurrection.bulia.SetActive(true);
        _BObj.SetActive(true);
        
        yield return new WaitForSeconds(4f);
        _resurrection.bulia.SetActive(false);
        _BObj.SetActive(false);
    }
    void Update()
    {
        if(_resurrection.dieFlag)
        {
            nokoriBOM = 2;
        }
        string Bom = nokoriBOM.ToString();
        _Text.text = "Bom "+Bom;
        /*for(int i=0;E_buret.Count() > i;i++)
        {
            GameObject _bullet = E_buret[i];
            if(_bullet.CompareTag("Enemy_bullet"))Destroy(_bullet);
        }*/
    }
}
