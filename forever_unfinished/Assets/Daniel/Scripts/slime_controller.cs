using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class slime_controller : MonoBehaviour
{

    public float move_speed;

    // rigid body of the slime
    private Rigidbody2D slime_rgdb;

    // indicates whether the slime is moving or not
    private bool is_moving;

    // how long the slime stops for before moving again
    public float time_betwixt_move;
    private float time_betwixt_move_tmp;
    // how long the silme will move for
    public float time_to_move;
    private float time_to_move_tmp;

    // direction the slime will move in
    private Vector3 move_dir;  

    // Start is called before the first frame update
    void Start()
    {
        slime_rgdb = GetComponent<Rigidbody2D>();
        time_betwixt_move_tmp = time_betwixt_move;
        time_to_move_tmp = time_to_move;
    }

    // Update is called once per frame
    void Update()
    {
        if (is_moving) {
            // update how long slime should walk for
            time_to_move_tmp -= Time.deltaTime;
            // make the slime move in our desired direction
            slime_rgdb.velocity = move_dir;

            // check if slime is done moving
            if (time_to_move_tmp < 0f) {
                is_moving = false;
                time_betwixt_move_tmp = time_betwixt_move;
            }

        } else {
            // update how long slime needs to wait for
            time_betwixt_move_tmp -= Time.deltaTime;
            // set velocity to zero to get rid of leftover velocity
            slime_rgdb.velocity = Vector2.zero;


            // if time between moving is done we reset time to move
            // and update to reflect slime is now moving
            if (time_betwixt_move_tmp < 0f) {
                is_moving = true;
                time_to_move_tmp = time_to_move;

                // randomly assign a direction for the slime to move in
                move_dir = new Vector3(Random.Range(-1f, 1f) * move_speed,
                                        Random.Range(-1f, 1f) * move_speed, 0f);
            }
        }
    }
}
