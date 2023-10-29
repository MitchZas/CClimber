using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClockHandMovement : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 1;
    public float mapHeight = 35;
    public float left = -12;
    public float right = 12;
    public float mapMin = -10;

    void Start(){
        transform.position = new Vector3(Random.Range(left, right), mapHeight, 0);
    }

    // Update is called once per frame
    void Update()
    {
        float vert = (Time.deltaTime * speed);
        transform.Translate(vert, 0f, 0f);

        if (transform.position.y < mapMin){
            Destroy(gameObject);
        }
    }
}
