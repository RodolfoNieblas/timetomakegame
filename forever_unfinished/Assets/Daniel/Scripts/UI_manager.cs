using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_manager : MonoBehaviour
{
    public Slider health_bar;
    public player_health player_health; // refers to the script player_health.cs

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        health_bar.maxValue = player_health.max_health;
        health_bar.value = player_health.cur_health;
    }
}
