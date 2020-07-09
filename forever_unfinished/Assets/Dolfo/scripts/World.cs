using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class World : SceneController   //This script is given to GameObject "GameController"
{
    public Transform player;
    
    public override void Start(){//this will run after sceneController.cs has completed running its own start function
        base.Start();


        //if you don't change camera position, the camera will move to player which may look weird or it may be what you want
        if(prevScene == "Earth" && prevKey == 1){
            player.position = new Vector3(-0.21f, -0.5f, 0f);
            Camera.main.transform.position = new Vector3(-0.21f, -0.5f, -10f);
        }
        else if(prevScene == "HoleOne" && prevKey == 1){
            player.position = new Vector3(3f, 8.37f, 0f);
            Camera.main.transform.position = new Vector3(3f, 8.37f, -10f);
        }
        else if(prevScene == "Earth" && prevKey == 2){
            player.position = new Vector3(-0.82f, -2.64f, 0f);
            Camera.main.transform.position = new Vector3(-0.82f, -2.64f, -10f);
        }
        else if(prevScene == "HoleTwo" && prevKey == 1){
            player.position = new Vector3(-2.51f, 6.18f, 0f);
            Camera.main.transform.position = new Vector3(-2.51f, 6.18f, -10f);
        }
       
    }
}
