using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleGenerator : MonoBehaviour
{
    public float mapHeight;
    public float mapLeftBorder;
    public float mapRightBorder;
    
    public float minTimeGen;
    public float maxTimeGen;
    float elapsedTime;
    float timeUntilNext;

    // Start is called before the first frame update
    void Start()
    {
        elapsedTime = 0;
        timeUntilNext = Random.Range(minTimeGen, maxTimeGen);
    }

    // Update is called once per frame
    void Update()
    {
        elapsedTime += Time.deltaTime;
        if (elapsedTime > timeUntilNext){
            //spawn new clock hand with position of top and between left and right borders
            if(Random.Range(0,2) > 1){
                //generate big hand
            }
            else{
                //generate small hand
            }
            elapsedTime = 0;
        }
    }
}
