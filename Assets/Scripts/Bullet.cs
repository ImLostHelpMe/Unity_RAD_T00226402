using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float life = 3;

    void Awake()
    {
        Destroy(gameObject, life);   
    }

    void OnCollisionEnter(Collision collision)
    {
        // Check if the collided object has the tag "Terrain"
        if (!collision.gameObject.CompareTag("Terrain"))
        {
            // Destroy the collided object (not the terrain)
            Destroy(collision.gameObject);
        }

        // Always destroy the bullet
        Destroy(gameObject);
    }
}
