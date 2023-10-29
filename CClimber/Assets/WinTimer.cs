using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinTimer : MonoBehaviour
{
    IEnumerator ExecuteAfterTime(float time)
    {
        var nextScene = SceneManager.GetActiveScene().buildIndex + 1;

        if (nextScene == 5)
        {
            nextScene = 0;
        }
        yield return new WaitForSeconds(time);

    // Code to execute after the delay

        SceneManager.LoadScene(nextScene);
    }

    public void Start () {
        StartCoroutine(ExecuteAfterTime(5));
    }

}
