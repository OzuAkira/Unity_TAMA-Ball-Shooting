using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HPgaiji : MonoBehaviour
{
    public int maxHP;
    public Slider slider;
    EnemyBasic HP;
    // Start is called before the first frame update
    void Start()
    {
        slider.value = 1;
        HP = GetComponent<EnemyBasic>();
    }

    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "Player_bullet")
            slider.value = (float)HP.Enemy_HP / (float)maxHP;
    }
}
