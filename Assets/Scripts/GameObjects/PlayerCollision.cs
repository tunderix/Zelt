using UnityEngine;

public class PlayerCollision : MonoBehaviour
{

    public PlatformerMovement movement;

    void OnCollisionEnter(Collision collisionInfo) 
    {   //Tähän tulee mihin osutaan. Nyt trackataan Tageja. Tämä voi    myös olla esim name.

        if (collisionInfo.collider.tag == "Esteet")
        {   //Tähän tulee mitä tapahtuu osuttua.
            movement.enabled = false;
        }
      
    }  
    //ToDo miten tämä tieto välitetään esteelle. (Movement arvo)
 
}
