using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class slime_controller : MonoBehaviour
{

    public float move_speed;

    private Rigidbody2D slimeRB;
    private bool isMoving;

    //Length in seconds of slime not moving
    public float slimeResting;
    private float slimeResting_private;

    //Length in seconds of slime moving
    public float slimeMoving;
    private float slimeMoving_private;

    //Velocity vector of slime will be set to this, so direction + speed
    private Vector2 move_dir;    

    
    void Start()
    {
        slimeRB = GetComponent<Rigidbody2D>();
        slimeResting_private = slimeResting;
        slimeMoving_private = slimeMoving;
    }

    // Update is called once per frame
    void Update()
    {
        if (isMoving) {
            // update how long slime should walk for
            slimeMoving_private -= Time.deltaTime;
            // make the slime move in our desired direction
            slimeRB.velocity = move_dir;

            // check if slime is done moving
            if (slimeMoving_private < 0f) {
                isMoving = false;
                slimeResting_private = slimeResting;
            }

        } else {
            // update how long slime needs to wait for
            slimeResting_private -= Time.deltaTime;
            // set velocity to zero to get rid of leftover velocity
            slimeRB.velocity = Vector2.zero;


            // if time between moving is done we reset time to move
            // and update to reflect slime is now moving
            if (slimeResting_private < 0f) {
                isMoving = true;
                slimeMoving_private = slimeMoving;

                // randomly assign a direction for the slime to move in
                move_dir = new Vector2(Random.Range(-1f, 1f) * move_speed, Random.Range(-1f, 1f) * move_speed);
            }                                                           
        }
    }
}


//Notes
/*
So we can create two different sequences. 
Sequence 1 - Slime moves towards player
Sequence 2 - Slime moves randomly
If we make the slime move randomly in very short bursts
 as it approaches the player it may look nice?
 */