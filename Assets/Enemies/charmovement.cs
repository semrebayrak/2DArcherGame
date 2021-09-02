using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class charmovement : MonoBehaviour
{
    public float speed = 10.0f;
    private Rigidbody2D rb;
    private Vector2 screenBounds;
    public Boolean zigzag = false;
    float y = 0;
    bool flag = false;

    // Use this for initialization
    void Start()
    {   y = transform.position.y;
        rb = this.GetComponent<Rigidbody2D>();
        if (!zigzag)
        {
           
            rb.velocity = new Vector2(-speed - Time.time / 100, 0);
            screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));



        }
        
    
          

    }

    // Update is called once per frame
    void Update()
    {
       

        if(zigzag)
        {
           


            if (y > transform.position.y + 1f)
                flag = false;
            else if (y < transform.position.y - 1f)
                flag = true;



            if (flag)
                rb.velocity = new Vector2(-speed - Time.time / 100, -speed - Time.time / 100);
            else
                rb.velocity = new Vector2(-speed - Time.time / 100, +speed + Time.time / 100);
        }
        else
        {

            if (transform.position.x < screenBounds.x * -0.80)
            {

                Destroy(this.gameObject);
            }
        }
    }
}