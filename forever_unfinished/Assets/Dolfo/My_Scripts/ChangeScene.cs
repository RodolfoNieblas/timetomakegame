using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeScene : MonoBehaviour // This script is to be given to entrances to different scenes !!!!!!
{
    [SerializeField] private string toScene; // [SerializeField] private value can now be manipulated in Unity
    [SerializeField] private int doorKey;
    private SceneController sceneController;
    
    
    
    

    void Start() {
        sceneController = GameObject.FindGameObjectWithTag("GameController").GetComponent<SceneController>();
        
    }

    private void OnTriggerEnter2D(Collider2D collision){
        if(collision.CompareTag("Player")){
            sceneController.giveKey(doorKey);
            sceneController.LoadScene(toScene);
        }
    }
}
