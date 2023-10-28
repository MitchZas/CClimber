using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class PlayerMovement : MonoBehaviour
{
    public float horizontal;
    public float speed = 5f;

    private Rigidbody2D rb2d;
    public float jump;



    public Vector2 boxSize;
    public float castDistance;
    public LayerMask groundLayer;
    
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    bool isGrounded(){
        if (Physics2D.BoxCast(transform.position, boxSize, 0, -transform.up, castDistance, groundLayer)){
            return true;
        }
        return false;
    }

    public void OnDrawGizmos(){
        Gizmos.DrawWireCube(transform.position - transform.up * castDistance, boxSize);
    }

    // Update is called once per frame
    void Update()
    {
        // Character Movement to move left and right 
        horizontal = Input.GetAxis("Horizontal");
        horizontal *= speed * Time.deltaTime;

        transform.Translate(new Vector3(horizontal, 0f, 0f));

        
        // Character jump
        if(Input.GetButtonDown("Jump") && isGrounded())
        {
            Debug.Log("Jump!");
            rb2d.AddForce(new Vector2(rb2d.velocity.x, jump));
        }
    }
}
