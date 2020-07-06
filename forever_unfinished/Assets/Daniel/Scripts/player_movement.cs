using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_movement : MonoBehaviour {

    public float speed;  //Floating point variable to store the player's movement speed.



    // Use this for initialization
    void Start()
    {

    }

    //FixedUpdate is called at a fixed interval and is independent of frame rate. Put physics code here.
    void Update()
    {
        //Store the current horizontal input in the float moveHorizontal.
        float moveHorizontal = Input.GetAxisRaw("Horizontal");

        //Store the current vertical input in the float moveVertical.
        float moveVertical = Input.GetAxisRaw("Vertical");

        //Use the two store floats to create a new Vector2 variable movement.
        Vector3 movement = new Vector3 (moveHorizontal, moveVertical, 0.0f);

        transform.position = transform.position + (movement.normalized * speed) * Time.deltaTime;
    }
}
