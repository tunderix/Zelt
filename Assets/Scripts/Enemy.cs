using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{   
    //Annetaan viholliselle HP
    public int health = 100;

    public GameObject deathEffect;

    //Logiikka, minkä perusteela vihollinen ottaa damagea
    public void TakeDamage (int damage)
    {
        health -= damage;
        
        if (health <= 0)
        {
            Die();
        }

    }
    //tässä tehdään Death effect
    void Die()
    {
        Instantiate(deathEffect, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }

}
