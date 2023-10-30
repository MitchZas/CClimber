using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Collision : MonoBehaviour
{

    public AudioClip deathSFX;
    private AudioSource audioSource;

    public void Start(){
        audioSource = GetComponent<AudioSource>();
    }
   private void OnCollisionEnter2D(Collision2D col) 
   {
        if(col.gameObject.tag == "Player")
        {
            //audioSource.PlayOneShot(deathSFX, 1);
            Destroy(col.gameObject);

            // Loads the death screen on death

            SceneManager.LoadScene(2);
        }
   }
}
