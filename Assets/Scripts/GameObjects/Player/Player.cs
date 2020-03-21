using UnityEngine;
public class Player : ZeltBehaviour
{
    bool m_HitDetect;

    [SerializeField]
    private Collider m_Collider;

    RaycastHit m_Hit;

    [SerializeField]
    private float m_MaxDistance;

    private bool touchingGround;

    private void FixedUpdate()
    {
        m_HitDetect = Physics.BoxCast(m_Collider.bounds.center, m_Collider.bounds.size, Vector3.down, out m_Hit, transform.rotation, 1.0f);
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = m_HitDetect ? Color.green : Color.red;
        Gizmos.DrawWireCube(m_Collider.bounds.center, m_Collider.bounds.size);
    }

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
            return m_HitDetect;
        }
    }
}
