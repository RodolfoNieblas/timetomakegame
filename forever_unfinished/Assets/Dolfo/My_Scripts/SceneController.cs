 using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //need it for this one

public class SceneController : MonoBehaviour //This script is given to GameObject "GameController"
{
    
    public static string prevScene = ""; //making this variable static allows us to use the variable without having to declare it inside unity
    public static string currentScene = "";
    public static int prevKey;
    //private ChangeScene changeScene;
    

    public virtual void Start(){ //we use "virtual" here so we can override this function on a script derived of this one aka World.cs
        currentScene = SceneManager.GetActiveScene().name;
        
        
    }

    public void giveKey (int key){//this function is used to carry over the contents of the key from class to class
        prevKey = key;
    }

    public void LoadScene(string sceneName){
        prevScene = currentScene;
        SceneManager.LoadScene(sceneName);
    }
}
