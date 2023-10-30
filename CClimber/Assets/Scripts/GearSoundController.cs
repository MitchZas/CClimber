using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GearSoundController : MonoBehaviour
{
    public AudioClip clipBounce;
    public AudioClip clipRoll;
    public AudioSource audioSource;
    public int clicksPerRotation = 6;


    private float previousRotation;

    float getRotation(){
        float rot = transform.rotation.z;
        if (rot < 0){
            return rot + 360;
        }
        return rot;
    }


    void Start(){
        audioSource = GetComponent<AudioSource>();
        previousRotation = getRotation();
    }

    void Update(){
        if(transform.position.y < -5)
        {
            Destroy(gameObject);
        }
        
        if(Mathf.Abs(previousRotation - getRotation()) >= 360/clicksPerRotation ){
            audioSource.PlayOneShot(clipRoll, 1);
            previousRotation = getRotation();
        }
    }
    private void OnCollisionEnter2D(Collision2D col) 
    { 
            if(col.gameObject.tag == "Ground")
            {
                audioSource.PlayOneShot(clipBounce, 1);
            }
    }


}
