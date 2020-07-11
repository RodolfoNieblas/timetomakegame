using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // I am using this header in order to change scenes


public class Player : MonoBehaviour
{
    //For movement
    public float speed;
    private Rigidbody2D Player_RigidBody2D;

    //For animation
    public Animator Player_Animator;
    bool right = false;
    bool left = false;
    bool up = false;
    bool down = false;

    

    void Start()
    {
        speed = 6f;
        Player_RigidBody2D = GetComponent<Rigidbody2D>();
        Player_Animator = GetComponent<Animator>();
    }

    
    void Update()
    {
        //Code for Movement
        float moveHorizontal = Input.GetAxisRaw("Horizontal");
        float moveVertical = Input.GetAxisRaw("Vertical");

        // if player moves anywhere then the velocity vector = speed
        if (moveHorizontal > 0.5f || moveHorizontal < -0.5f || moveVertical > 0.5f || moveVertical < -0.5f)  
        {
            Player_RigidBody2D.velocity = new Vector2(moveHorizontal, moveVertical).normalized * speed;
        }
        
        // When we release 'a' or 'd' then the player stops moving horizontally
        else if (moveHorizontal < 0.5f && moveHorizontal > -0.5f) { 
            Player_RigidBody2D.velocity = new Vector2(0f, moveVertical).normalized;
        }

        // When we release 'w' or 's' then the player stops moving vertically
        else if (moveVertical < 0.5f && moveVertical > -0.5f) {
            Player_RigidBody2D.velocity = new Vector2(moveHorizontal, 0f).normalized;
        }
        


        //Code for Animator
        if(Input.GetKeyDown(KeyCode.W)){
            up = true;
            Player_Animator.SetBool("Up", up);
        }
        else if(Input.GetKeyUp(KeyCode.W)){
            up = false;
            Player_Animator.SetBool("Up", up);
        }
        else if(Input.GetKeyDown(KeyCode.D)){
            right = true;
            Player_Animator.SetBool("Right", right);
        }
        else if(Input.GetKeyUp(KeyCode.D)){
            right = false;
            Player_Animator.SetBool("Right", right);
        }
        else if(Input.GetKeyDown(KeyCode.A)){
            left = true;
            Player_Animator.SetBool("Left", left);
        }
        else if(Input.GetKeyUp(KeyCode.A)){
            left = false;
            Player_Animator.SetBool("Left", left);
        }
        else if(Input.GetKeyDown(KeyCode.S)){
            down = true;
            Player_Animator.SetBool("Down", down);
        }
        else if(Input.GetKeyUp(KeyCode.S)){
            down = false;
            Player_Animator.SetBool("Down", down);
        }
    }
}
