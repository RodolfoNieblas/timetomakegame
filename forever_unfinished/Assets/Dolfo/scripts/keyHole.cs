using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class keyHole : MonoBehaviour
{
    private itemPickup itempickup;
    public SpriteRenderer hole_Renderer;
    public BoxCollider2D hole_Collider2D;
    
    void Start()
    {
        GetComponent<SpriteRenderer>().enabled = true;
        hole_Renderer.enabled = false;
        hole_Collider2D.enabled = false;
        itempickup = GameObject.FindGameObjectWithTag("Key").GetComponent<itemPickup>();
    }

    private void OnTriggerEnter2D(Collider2D collision){
        if(collision.CompareTag("Player")){
           if(itempickup.pickedUp == true){
                hole_Renderer.enabled = true;
                hole_Collider2D.enabled = true;
                GetComponent<SpriteRenderer>().enabled = false;
           }
        }
    }
}
