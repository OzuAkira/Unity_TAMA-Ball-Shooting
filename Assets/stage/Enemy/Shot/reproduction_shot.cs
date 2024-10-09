using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class reproduction_shot : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject E_bulletObj;
    float shot_angle = -30.0f;
    float timeCount = 0;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timeCount+= Time.deltaTime;
        shot_angle += 10;
        if (timeCount >= 6 && timeCount <= 17){
          GameObject createObj = Instantiate(E_bulletObj,transform.position,Quaternion.identity);
          EnemyShot E_shotscript = createObj.GetComponent<EnemyShot>();
          E_shotscript.Init(shot_angle,2);
        }
        if(timeCount >= 27.5f && timeCount <28)
        {
          timeCount = 0;
        }
    }
}
