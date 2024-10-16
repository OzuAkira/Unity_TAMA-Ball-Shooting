using UnityEngine;

public class fiveway : MonoBehaviour
{
    private float timer = 0;
    public float speed = 10;
    private int frame = 0;
    //private int time = 0;
    private int count = 0;
    private int X = 120;
    private bool onef = false;
    public GameObject bulletObj;
    private GameObject playerObj;
    private float firstS = 18;
    private float limit = 33.5f;

    // Start is called before the first frame update
    void Start()
    {
        playerObj = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        frame++;
        timer += Time.deltaTime;
        if(timer >= firstS && frame%X == 0)
        {
            if(playerObj == null){playerObj = GameObject.Find("Player");}
            else
            count++;
            X = 45;
            var pos = gameObject.transform.position;
            var bullet = Instantiate(bulletObj);
            bullet.transform.position = pos;
            Vector2 vec = playerObj.transform.position - pos;
            Vector2 vec_1 = vec + new Vector2(0.5f,0.5f);
            Vector2 vec_2 = vec + new Vector2(-0.5f,0.5f);
            Vector2 vec_3 = vec + new Vector2(1f,1);
            Vector2 vec_4 = vec + new Vector2(-1f,1);
            Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
            rb.velocity = vec * speed;
                bullet = Instantiate(bulletObj,gameObject.transform.position - new Vector3(-0.5f,0) ,Quaternion.identity);
            rb = bullet.GetComponent<Rigidbody2D>();
            rb.velocity = vec_1 * speed;
                bullet = Instantiate(bulletObj,gameObject.transform.position - new Vector3(0.5f,0),Quaternion.identity);
            rb = bullet.GetComponent<Rigidbody2D>();
            rb.velocity = vec_2 * speed;

            bullet = Instantiate(bulletObj,gameObject.transform.position - new Vector3(-1f,0),Quaternion.identity);
            rb = bullet.GetComponent<Rigidbody2D>();
            rb.velocity = vec_3 * speed;

            bullet = Instantiate(bulletObj,gameObject.transform.position - new Vector3(1f,0),Quaternion.identity);
            rb = bullet.GetComponent<Rigidbody2D>();
            rb.velocity = vec_4 * speed;
        }
        /*if(count>2){
            count = 0;
            //time = 0;
            X = 60; 
        }*/
    
            //bullet.transform.position;
        

        if(timer >= limit && timer < limit + 0.5f )
        {
            timer = 0;
            onef = true;
        }
        if(onef && firstS == 18)
        {
            firstS = 12f;
            limit = limit - 6;
        }
        //Debug.Log("time="  + timer + "limit=" + limit);
    }
}

    
   

