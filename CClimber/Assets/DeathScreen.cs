using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathScreen : MonoBehaviour
{
    public void RestartGame ()
    {
        Debug.Log ("Restarting game");
        SceneManager.LoadScene(1);
    }

    public void BackToMenu ()
    {
        Debug.Log ("Exiting to menu");
        SceneManager.LoadScene(0);
    }
}
