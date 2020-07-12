using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Note: enemy with this script must have "is trigger" checked for this
// script to work properly
public class damage_player : MonoBehaviour
{
    public int dmg_to_give;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Player")) {
            // if the enemy which script is on collides with object which 
            // has the tag Player than we use the HurtPlayer function in
            // player_health.cs to reduce the current health.
            other.gameObject.GetComponent<player_health>().HurtPlayer(dmg_to_give);
        }
    }
}
