using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleGenerator : MonoBehaviour
{
    
    public float minTimeGen;
    public float maxTimeGen;
    float elapsedTime;
    float timeUntilNext;

    public GameObject hourHand;
    public GameObject minuteHand;

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
        Debug.Log(elapsedTime + " VS " + timeUntilNext);
        Debug.Log(elapsedTime > timeUntilNext);
        if (elapsedTime > timeUntilNext){
            //spawn new clock hand with position of top and between left and right borders

            if(Random.Range(0,2) > 1f){
                //generate big hand
                Instantiate(minuteHand, transform);
            }
            else{
                //generate small hand
                Instantiate(hourHand, transform);
            }
            elapsedTime = 0;
        }
    }
}
