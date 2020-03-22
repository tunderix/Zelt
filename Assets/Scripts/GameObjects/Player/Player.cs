using UnityEngine;
public class Player : ZeltBehaviour
{
    //Internal boolean for touching ground
    [SerializeField]
    private bool boxCast;

    [SerializeField]
    private Collider jumpTrigger;

    // Variable to store the jumpTrigger hit
    RaycastHit m_Hit;

    private void FixedUpdate()
    {
        Physics.BoxCast(jumpTrigger.bounds.center, jumpTrigger.bounds.size, Vector3.down, out m_Hit, transform.rotation, 1.0f);
        if (m_Hit.collider != null)
        {
            boxCast = true;
        }
        else
        {
            boxCast = false;
        }
    }

    //Just for debugging if player is touching ground
    private void OnDrawGizmos()
    {
        //Draw the jump trigger as green or red depending on trigger
        Gizmos.color = boxCast ? Color.red : Color.blue;
        Gizmos.DrawWireCube(jumpTrigger.bounds.center, jumpTrigger.bounds.size);
    }


    //
    // PUBLIC HOOKS
    //

    public Rigidbody PlayerRigidbody
    {
        get
        {
            return this.GetComponent<Rigidbody>();
        }
    }

    public bool isGrounded
    {
        get
        {
            return boxCast;
        }
    }
}
