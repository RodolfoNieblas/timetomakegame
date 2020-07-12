using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileUp : MonoBehaviour
{
    public float speed;

    void Update()
    {
        transform.Translate(transform.up * speed * Time.deltaTime, Space.World);
    }
}
