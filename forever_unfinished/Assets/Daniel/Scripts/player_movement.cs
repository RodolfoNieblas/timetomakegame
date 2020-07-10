using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_movement : MonoBehaviour {

    public float speed;  //Floating point variable to store the player's movement speed.

    private Animator player_anim;
    private Rigidbody2D player_rgdb;

    private bool is_moving;


    // Use this for initialization
    void Start()
    {
        player_anim = GetComponent<Animator>();
        player_rgdb = GetComponent<Rigidbody2D>();
    }

    //FixedUpdate is called at a fixed interval and is independent of frame rate. Put physics code here.
    void Update()
    {
        //Store the current horizontal input in the float moveHorizontal.
        float moveHorizontal = Input.GetAxisRaw("Horizontal");

        //Store the current vertical input in the float moveVertical.
        float moveVertical = Input.GetAxisRaw("Vertical");

        if (moveHorizontal > 0.5f || moveHorizontal < -0.5f
        || moveVertical > 0.5f || moveVertical < -0.5f) {
            // adjust the velocity of our rigidbody
            player_rgdb.velocity = new Vector2(moveHorizontal, moveVertical).normalized * speed;
        }

        // player no longer wants to move horizontally
        if (moveHorizontal < 0.5f && moveHorizontal > -0.5f) {
            player_rgdb.velocity = new Vector2(0f, moveVertical).normalized * speed;
        }

        // player no longer wants to move vertically
        if (moveVertical < 0.5f && moveVertical > -0.5f) {
            player_rgdb.velocity = new Vector2(moveHorizontal, 0f).normalized * speed;
        }
    }
}
