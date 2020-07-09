using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class itemPickup : MonoBehaviour
{
    public bool pickedUp;

    void Start(){
        pickedUp = false;
    }

    private void OnTriggerEnter2D(Collider2D collision){
        if(collision.CompareTag("Player")){
            GetComponent<SpriteRenderer>().enabled = false;
            pickedUp = true;
        }
    }
}
