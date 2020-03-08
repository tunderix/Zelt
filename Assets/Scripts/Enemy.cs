using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{   
    //Annetaan viholliselle HP
    [SerializeField]
    [Tooltip("Monsterin HP")]
    private int health;

    [Tooltip("Anna death animaatio")]
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
