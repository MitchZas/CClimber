using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    AudioSource audioSource;
    public AudioClip clipPlay;
    public AudioClip clipQuit;
    public void Start(){
        audioSource = GetComponent<AudioSource>();
    }
    public void PlayGame () 
    {
        audioSource.PlayOneShot(clipPlay, 1);
        Debug.Log ("Playing game");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void QuitGame ()
    {
        audioSource.PlayOneShot(clipQuit, 1);
        Debug.Log ("QUITTING GAME");
        Application.Quit();
    }
    
}
