using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Bom : MonoBehaviour
{
    public int nokoriBOM = 2;
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
            Debug.Log("Fire!!");
        }
    }
    IEnumerator C_FireB()
    {
        _resurrection.bulia.SetActive(true);
        _BObj.SetActive(true);
        M_FireB();
        yield return new WaitForSeconds(4f);
        _resurrection.bulia.SetActive(false);
        _BObj.SetActive(false);
    }
    void M_FireB()
    {
        
        /*for(int i=0;E_buret.Count() > i;i++)
        {
            GameObject _bullet = E_buret[i];
            if(_bullet.CompareTag("Enemy_bullet"))Destroy(_bullet);
        }*/
    }
}
