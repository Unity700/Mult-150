using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour

{
    void Start()
    {
        float health = 1004f;
        float poisonDamage = 125.5f;

        Debug.Log(health);  // 1004

        health -= poisonDamage;
        Debug.Log(health);  // 878.5

        // Repeat until health reaches 0
        health -= poisonDamage;
        Debug.Log(health);  // 753

        health -= poisonDamage;
        Debug.Log(health);  // 627.5

        health -= poisonDamage;
        Debug.Log(health);  // 502

        health -= poisonDamage;
        Debug.Log(health);  // 376.5

        health -= poisonDamage;
        Debug.Log(health);  // 251

        health -= poisonDamage;
        Debug.Log(health);  // 125.5

        health -= poisonDamage;
        Debug.Log(health);  // 0

        Debug.Log("Player has been unalived!");
    }
}

