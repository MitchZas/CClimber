using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinCondition : MonoBehaviour
{
    public AudioClip winSFX;
    private AudioSource audioSource;
    
    private void OnTriggerEnter2D(Collider2D col) 
    {
        if(col.gameObject.tag == "Player")
        {
            audioSource.PlayOneShot(winSFX, 1);

            // Loads the win screen on enter

            //SceneManager.LoadScene(3);
        } 
    }
}
