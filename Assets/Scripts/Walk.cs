using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Walk : MonoBehaviour
{

    public float maxSpeed;
    public float minSpeed;
    public float speed;
    public float scale;
    
    public Rigidbody2D rb;

    void Start()
    {
        speed = minSpeed;
        rb = GetComponent<Rigidbody2D>();
    }


    void FixedUpdate()
    {
        Check();
        
        if (Input.GetKey(KeyCode.A)) //left
        {
            //speed += scale;
            rb.constraints = RigidbodyConstraints2D.None;
            rb.velocity = transform.TransformVector(-1,0,0) * speed;
        } 
        else if(Input.GetKey(KeyCode.D)) //right
        {
            rb.constraints = RigidbodyConstraints2D.None;
            rb.velocity = transform.TransformVector(1,0,0) * speed;
            //speed += scale;
            //rb.velocity = Vector2.right * speed * Time.deltaTime;
        }
        
        if(Input.GetKeyUp(KeyCode.D) || Input.GetKeyUp(KeyCode.A))
        {
            rb.constraints = RigidbodyConstraints2D.FreezeAll;
        }
    }

    void Check()
    {
        if (speed > maxSpeed)
        {
            speed = maxSpeed;
        }

        if (speed < minSpeed)
        {
            speed = minSpeed;
        }
    }
}
