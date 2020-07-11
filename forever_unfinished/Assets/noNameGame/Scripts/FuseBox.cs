using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.Rendering.Universal; //for 2D lights

public class FuseBox : MonoBehaviour
{
    private Light2D post;

    void Start()
    {
        post = GameObject.FindGameObjectWithTag("LightPost").GetComponent<Light2D>();
        post.enabled = false;
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player")){
            post.enabled = true;
        }
    }
   
}
