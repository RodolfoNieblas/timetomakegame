using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileDown : MonoBehaviour
{
    public float speed;
    
    void Update()
    {
        transform.Translate(transform.up * speed * Time.deltaTime * -1, Space.World);
    }
}
