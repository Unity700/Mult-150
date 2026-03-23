using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int health = 100;

    void Start()
    {
        int damage = 10;

        Debug.Log("Starting health: " + health);

        // First hit (reuse from Part 1 style)
        health -= damage;
        Debug.Log("After first hit, health: " + health);

        // Now keep damaging until health reaches 0 or below
        while (health > 0)
        {
            health -= damage;
            Debug.Log("Player took damage, health is now: " + health);
        }

        Debug.Log("Player has been unalived!");
    }
}
