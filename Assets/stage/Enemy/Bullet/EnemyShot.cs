using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class EnemyShot : MonoBehaviour
{
    [SerializeField] float angle;
    [SerializeField] float speed;
    Vector3 velocity;
    // Start is called before the first frame update
    void Start()
    {
        velocity.x = speed * Mathf.Cos(angle * Mathf.Deg2Rad);
        velocity.y = speed * Mathf.Sin(angle * Mathf.Deg2Rad);
        float zAngle = Mathf.Atan2(velocity.y,velocity.x) * Mathf.Rad2Deg - 90.0f;
        transform.rotation = Quaternion.Euler(0,0,zAngle);
        Destroy(gameObject,5.0f);
    }
    private void OnTriggerEnter2D(Collider2D other) {
      /*  if (other.gameObject.CompareTag("Player")){
            other.gameObject.SetActive(false);
            Debug.Log(other);
        }*/
        if (other.gameObject.CompareTag("Wall") || other.gameObject.CompareTag("bulia")){
            Destroy(gameObject,5);
        }
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += velocity * Time.deltaTime;
    }

    public void Init(float input_angle, float input_speed){
        angle = input_angle;
        speed = input_speed;
    }
}
