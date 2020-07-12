﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileLeft : MonoBehaviour
{
    public float speed;
    
    void Update()
    {
       transform.Translate(transform.right * speed * Time.deltaTime * -1, Space.World);
    }
}
