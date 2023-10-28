using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public GameObject player;
    Camera c;
    public int offsetRatio = 70;
    private float offsetValue;
    public int maxHeight = 1000;
    public int minHeight = -2;

    // Start is called before the first frame update
    void Start()
    {
        c = GetComponent<Camera>();
        offsetValue = (offsetRatio * c.orthographicSize / 100);
    }

    // Update is called once per frame
    void Update()
    {
        //get camerax and y
        //vertical halfheight
        Debug.Log(c.orthographicSize);
        //horizontal halfwidth

        Debug.Log(offsetValue);
        float upHeight;
        float downHeight;
        upHeight = c.transform.position.y + offsetValue;
        downHeight = c.transform.position.y - offsetValue;

        Debug.Log("Uheight: " + upHeight + " Dheight: " + downHeight);

        Debug.Log("Camera Position: " + c.transform.position);

        

        if(player.transform.position.y > upHeight){
            Debug.Log("Going Up");
            c.transform.position = new Vector3(0, c.transform.position.y + (player.transform.position.y - upHeight) , -10);
            if(c.transform.position.y > maxHeight){
                c.transform.position = new Vector3(0,maxHeight,-10);
            }
        }
        if(player.transform.position.y < downHeight){
            Debug.Log("Going Down");
            c.transform.position = new Vector3(0, c.transform.position.y - (downHeight - player.transform.position.y) , -10);
            if (c.transform.position.y < minHeight){
                c.transform.position = new Vector3(0,minHeight,-10);
            }

        }
    }
}
