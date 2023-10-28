using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{
   private void OnCollisionEnter2D(Collision2D col) 
   {
        if(col.gameObject.tag == "Player")
        {
            Destroy(col.gameObject);
        }
   }
}
