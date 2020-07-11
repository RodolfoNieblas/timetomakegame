using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_health : MonoBehaviour
{
    public int max_health;
    public int cur_health; // current health of the player

    public void HurtPlayer (int dmg_taken) {
        cur_health -= dmg_taken;
    }


    // Start is called before the first frame update
    void Start()
    {
        cur_health = max_health;   
    }

    // Update is called once per frame
    void Update()
    {
        if (cur_health < 0) {
            // if the player's health drops below 0, the game object which this
            // script is attached to, the player, will be disabled.  Meaning
            // all of its components will deactivated.
            gameObject.SetActive(false);
        }   
    }
}
