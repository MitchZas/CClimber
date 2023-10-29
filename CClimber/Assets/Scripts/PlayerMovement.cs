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

    private bool previousGrounded;
    private bool playerGrounded;

    public Vector2 boxSize;
    public float castDistance;
    public LayerMask groundLayer;
    
    public AudioClip clipJump;
    public AudioClip clipLand;
    AudioSource audioSource;
    
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        audioSource = GetComponent<AudioSource>();
        previousGrounded = false;
        playerGrounded = false;
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
        if(isGrounded())
        {
            if(!previousGrounded){
                audioSource.PlayOneShot(clipLand, 1);
            }
            previousGrounded = true;

            if(Input.GetButtonDown("Jump") ){
                Debug.Log("Jump!");
                rb2d.AddForce(new Vector2(rb2d.velocity.x, jump));
                audioSource.PlayOneShot(clipJump, 1);
            }
        }
        else{
            previousGrounded = false;
        }
    }
}
