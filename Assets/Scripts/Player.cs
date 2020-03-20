using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Rigidbody PlayerRigidbody
    {
        get
        {
            return this.GetComponent<Rigidbody>();
        }
    }
}
