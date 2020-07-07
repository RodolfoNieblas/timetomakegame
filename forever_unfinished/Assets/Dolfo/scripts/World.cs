using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class World : SceneController   //This script is given to GameObject "GameController"
{
    public Transform player;
    
    public override void Start(){//this will run after sceneController.cs has completed running its own start function
        base.Start();


        //if you don't change camera position, the camera will move to player which may look weird or it may be what you want
        if(prevScene == "Moon" && prevKey == 3){
            player.position = new Vector3(-5.44f, 0.8324f, 0f);
            Camera.main.transform.position = new Vector3(-5.44f, 0.8324f, -10f);
        }
        else if(prevScene == "Moon" && prevKey == 4){
            player.position = new Vector3(5.0761f, -0.492f, 0f);
            Camera.main.transform.position = new Vector3(5.0761f, -0.492f, -10f);
        }
        else if(prevScene == "Spaceship Store" && prevKey == 1){
            player.position = new Vector3(0.31f, 8.06f, 0f);
            Camera.main.transform.position = new Vector3(0.31f, 8.06f, -10f);
        }
        else if(prevScene == "Spaceship Store" && prevKey == 2){
            player.position = new Vector3(0f, -11f, 0f);
            Camera.main.transform.position = new Vector3(0f, -11f, -10f);
        }
    }
}
