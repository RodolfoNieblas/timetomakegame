using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.Rendering.Universal; //for 2D lights

public class FuseBox : MonoBehaviour
{
    public bool fuseboxON;


    void Start()
    {
        fuseboxON = false;
        
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player")){
            fuseboxON = true;
        }
    }
   
}
