using UnityEngine;

public class Shooting : ZeltBehaviour

{
        
    public Transform firePoint;
    public GameObject bulletPreFab;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }

    void Shoot ()
    {
        //Tänne kaikki Shoot-logiikat.
        Instantiate(bulletPreFab, firePoint.position, firePoint.rotation);
    }
}
