using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractSystem : MonoBehaviour
{
    [SerializeField] private bool triggerActive = false;

    private bool withPlayer;
    private Collider2D collider;
    private Rigidbody2D rb2d;
    private GameObject gameObj;

    public AudioSource audioSource;
    public AudioClip clipGrab;
    public AudioClip clipDrop;

    public int shootForce = 5;

    void Start(){
        withPlayer = false;
        collider = GetComponent<Collider2D>();
        rb2d = GetComponent<Rigidbody2D>();
        audioSource = GetComponent<AudioSource>();
    }

    private void OnCollisionEnter2D(Collision2D col) 
    {
        gameObj = col.gameObject;

            if(col.gameObject.tag == "Player")
            {
                triggerActive = true;
                Debug.Log("Touching Player");
            }
    }

        private void OnCollisionExit2D(Collision2D col) 
    {
            if(col.gameObject.tag == "Player")
            {
                triggerActive = false;
                Debug.Log("Not Touching Player");
            }
    }
    public void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Player"))
            {
                triggerActive = true;
                Debug.Log("Touching Player");
                //add highlight
            }
        }
 
    public void OnTriggerExit(Collider other)
        {
            if (other.CompareTag("Player"))
            {
                triggerActive = false;
                Debug.Log("not touching player");
                //remove highlight
            }
        }
 
    private void followPlayer(){
        withPlayer = true;
        collider.enabled = false;
        rb2d.gravityScale = 0;
        audioSource.PlayOneShot(clipGrab, 1);

        //turn off collision
        //turn off gravity
    }
    private void unfollowPlayer(){
        withPlayer = false;
        collider.enabled = true;
        rb2d.gravityScale = 1;
        audioSource.PlayOneShot(clipDrop, 1);

        transform.position = gameObj.transform.position + new Vector3(2, 0, 0);
    }

    private void Update()
        {
            if (withPlayer){
                //set position to be above player
                transform.position = gameObj.transform.position + new Vector3(0, 1.5f, 0);
            }

            if(Input.GetKeyDown(KeyCode.E)){
                if(withPlayer){
                    unfollowPlayer();
                }
                else if (triggerActive){
                    followPlayer();
                }
            }
            if (!withPlayer && triggerActive && Input.GetKeyDown(KeyCode.E))
            {
                Debug.Log("You did it!");
                

            }
            
}
    
            
}
