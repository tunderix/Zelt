using UnityEngine;

public class Player : ZeltBehaviour
{
    
    public Rigidbody PlayerRigidbody
    {
        get
        {
            return this.GetComponent<Rigidbody>();
        }
    }
}
