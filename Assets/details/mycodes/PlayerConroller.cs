using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerConroller : MonoBehaviour
{

    private Rigidbody2D rb;
    

    private Animator anim;
    public float speed;
    bool alt = true;
    private Vector2 screenBounds;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
         
    }
    void Update()
    {
       
        Vector2 position = this.transform.position;
        if (Time.timeScale ==  0)
        {
            position.x += 0;
            this.transform.position = position;


        }
        else if (Time.timeScale == 1)
        {
            position.x += speed; 
            this.transform.position = position;

        }


        hareket();
    }

    public void hareket()
    {
        if (alt)
        {
            transform.position = Vector3.Lerp(transform.position, new Vector3(transform.position.x, -2f, transform.position.z), Time.deltaTime * 3.0f);
        }
        else
        {
            transform.position = Vector3.Lerp(transform.position, new Vector3(transform.position.x, 2.5f, transform.position.z), Time.deltaTime * 3.0f);
        }

        transform.Translate(0, 0, 5 * Time.deltaTime);
    }

    public void UstPlatform()
    {
        alt = false;
    }
    public void altPlatform()
    {
        alt = true;
    }

    //float velocity  = 0f;
    //float speed = 4f;
    //float jumpAmount = 3f;

    /*
     * update
       velocity = joystick.horizontal * speed;
       //transform.position += velocity * speed * time.deltatime; 
       anim.setfloat("speed", mathf.abs(ınput.getaxis("horizontal")));

       if (ınput.getbuttondown("jump") && mathf.approximately(rb.velocity.y, 0))
       {
           rb.addforce(vector3.up * jumpamount, forcemode2d.ımpulse);
       }


       if (ınput.getaxisraw("horizontal") == -1)
       {
           transform.rotation = quaternion.euler(0f, 180f, 0f);
       }
       else if (ınput.getaxisraw("horizontal") == 1)
       {
           transform.rotation = quaternion.euler(0f, 0f, 0f);
       }
       */
}
