using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class obstackle : MonoBehaviour
{
    public float speed ;
    private Rigidbody2D rb;
    private Vector2 screenBounds;

    public static time zaman;

    // Use this for initialization
    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(-speed, 0);
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));

    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < screenBounds.x / 2)
        {
            Destroy(this.gameObject);
        }


        if (time.zaman>50)
        {
            speed = 10;
        }
        else if (time.zaman>60)
        {
            speed = 15;
        }
        else if (time.zaman>70)
        {
            speed = 20;
        }
        else if (time.zaman>80)
        {
            speed = 25;
        }
        
        

    }

    void OnTriggerEnter2D()
    {
        if (this.gameObject.tag == "virus")
        {
            Destroy(this.gameObject);
        }
    }
}
