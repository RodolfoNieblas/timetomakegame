using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class slime_follows : MonoBehaviour
{
    //Important notes about public variables
    /*
    Slime Speed -- When set to a value between 0 & 1. 
                  Why? To make slime slower than the player
                  What happens? The closer the slime gets to the player the slower it moves. 

                  When set to 1.
                  Why? To have constant movement.
                  What happens? The slime does not slow down the closer it gets to the player.

    Rand Range -- The lower the value, the higher you should set the random sequence timer.
                  Why? So the jitter is noticeable.

                  The HIGHER the value, the LOWER you should set the random sequence timer.
                  Why? So the slime actually follows the player instead of going all over the screen.

    Regular Sequence -- When set to 0. AND random sequence is set to a value above 0
                        What happens? It makes the slime take a completely jittery path towards player.

    Random Sequence -- When set to 0. AND regular sequence is set to a value above 0.
                       What happens? It makes the slime take a completely smooth path towards player.

    
     */

    public float slimeSpeed;
    public float randRange; //The higher this variable is increased, the higher the jitter

    private Transform player;

    private Rigidbody2D slimeRB;
    private SpriteRenderer slimeRenderer;

    private float playerX;  //These are the X and Y coordinates of the player and slime
    private float playerY;        
    private float slimeX;
    private float slimeY;   

    private float slimeVelX;    //Velocity vector X-axis of slime
    private float slimeVelY;    //Velocity vector Y-axis of slime

    public float regularSequence;           //Time in which slime follows player smoothly
    private float regularSequencePrivate;

    public float randomSequence;            //Time in which slime follows player with jitter
    private float randomSequencePrivate;

    private bool RandomMovement;

    
   


    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        slimeRB = GetComponent<Rigidbody2D>();
        slimeRenderer = GetComponent<SpriteRenderer>();
        slimeRenderer.enabled = true; //just for safety

        regularSequencePrivate = regularSequence;
        randomSequencePrivate = randomSequence;
        RandomMovement = false;
    }

    
    void Update() //Mathf.Sqrt(); Mathf.Abs(); for square root and absolute value
    {
        //Assigning needed variables, must be in Update as they are constantly changing
        slimeX = this.transform.position.x;
        slimeY = this.transform.position.y;

        playerX = player.position.x;
        playerY = player.position.y;

        slimeVelX = playerX - slimeX;
        slimeVelY = playerY - slimeY;


        if(RandomMovement == false)
        {
            regularSequencePrivate -= Time.deltaTime; //Counting down the timer for the regular sequence
            slimeRB.velocity = new Vector2(slimeVelX * slimeSpeed, slimeVelY * slimeSpeed); //velocity vector is straight line towards player

            if(regularSequencePrivate <= 0f) //if the regular sequence is over
            { 
                RandomMovement = true;        //then the random movement begins
                randomSequencePrivate = randomSequence;//Resetting timer for random sequence
            }
        }
        else 
        {
            randomSequencePrivate -= Time.deltaTime; //Counting down the timer for the random sequence
            
            //We take a random velocity vector and add it to the velocity vector that follows the player
            //We still need to control the speed so we multiply the new jittery velocity vector to our specified slime speed
            slimeRB.velocity = new Vector2((Random.Range(randRange * -1f, randRange) + slimeVelX) * slimeSpeed, 
                                            (Random.Range(randRange * -1f, randRange ) + slimeVelY) * slimeSpeed);

            if(randomSequencePrivate <= 0f) //if the random sequence is over
            {
                RandomMovement = false; //then the regular movement begins
                regularSequencePrivate = regularSequence; //Resetting timer for regular sequence
            }
        }

        //If the slime gets close enough to the player, it explodes
        if(Mathf.Abs(slimeVelX) <= 1f && Mathf.Abs(slimeVelY) <= 1f)
        {
            slimeRenderer.enabled = false;
        }

        
    }
}
