using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHit : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        // Check if the collided object has the tag "Player"
        if (collision.gameObject.CompareTag("Player"))
        {
            // Call a method to handle player death
            PlayerDeath(collision.gameObject);
        }
    }

    void PlayerDeath(GameObject player)
    {
        Destroy(player);
    }
}
