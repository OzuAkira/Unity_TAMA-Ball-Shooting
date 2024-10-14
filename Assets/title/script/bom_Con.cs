using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bom_Con : carsol
{
    // Start is called before the first frame update
    public imo imo;
    public override void Select()
    {
        imo = gameObject.GetComponent<imo>();
        GetComponent<AudioSource>().Play();
        imo.StartRebinding();

        //Debug.Log("teisoku="OnSprite);
    }
}
