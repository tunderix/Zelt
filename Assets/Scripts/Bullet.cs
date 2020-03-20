using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    //panoksen nopeus
    public float speed = 20f;
    //Panoksen vahinko
    [SerializeField]
    private int damage = 10;

    public Rigidbody2D rb;

    public GameObject impactEffect;
    // Start is called before the first frame update
    void Start()
    {
        rb.velocity = transform.right * speed;
    }


    void OnTriggerEnter2D(Collider2D hitInfo) 
    {
       

        Enemy enemy = hitInfo.GetComponent<Enemy>();
        if (enemy != null)
        {
             enemy.TakeDamage(damage);
        }

        Instantiate(impactEffect, transform.position, transform.rotation);
        Destroy(gameObject);
    }
    
    // GameObject.FindGameObjectWithTag("EnemyFrog").GetComponent<Animation>().Play("Tongue");  -> Esimerkki, miten animaatio liitetään kiinni tapahtumaan.

   
}
