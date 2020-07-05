using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileCollision : MonoBehaviour
{

    private Player player;

    void Start(){
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
    }

     private void OnTriggerEnter2D(Collider2D collision){
        if(collision.CompareTag("Player")){
            player.speed = 0f;
        }
    }
}
