using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.Rendering.Universal; //for 2D lights

public class LightingScripts : MonoBehaviour
{

    private Light2D lights;
    private float duration = 1.0f;
    private Color color0 = Color.red;
    private Color color1 = Color.blue;
    private FuseBox fusebox;

    
    void Start()
    {
        lights = GetComponent<Light2D>();
        lights.enabled = false;
        fusebox = GameObject.FindGameObjectWithTag("FuseBox").GetComponent<FuseBox>(); 
        
    }

    
    void Update()
    {
        //makes light bounce from red to blue
        if(fusebox.fuseboxON == true)
        {
            lights.enabled = true;
        float time = Mathf.PingPong(Time.time, duration) / duration;
        lights.color = Color.Lerp(color0, color1, time);
        }
        
    }
}
