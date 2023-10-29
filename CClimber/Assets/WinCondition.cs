using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinCondition : MonoBehaviour
{
    public AudioClip winSFX;
    private AudioSource audioSource;
    
    private void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.gameObject.tag== "Player")
        {
            //audioSource.PlayOneShot(winSFX, 1);
            SceneManager.LoadScene(3);
        }
    }
}
