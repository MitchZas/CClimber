using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float horizontal;
    public float speed = 5f;

    private Rigidbody2D rb2d;
    public float jump;
    
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        // Character Movement to move left and right 
        horizontal = Input.GetAxis("Horizontal");
        horizontal *= speed * Time.deltaTime;

        transform.Translate(new Vector3(horizontal, 0f, 0f));

        if(Input.GetButtonDown("Jump"))
        {
            rb2d.AddForce(new Vector2(rb2d.velocity.x, jump));
        }
    }
}
