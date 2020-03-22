using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 
// The jumping is controlled here, 
// The movement IS NOT APPLIED in here, but actually in PlatformerMovement.cs
// The movement is applied as rigidbody.MovePosition()
//

[RequireComponent(typeof(Player), typeof(PlayerInputs))]
public class JumpController : ZeltBehaviour
{

    // Holds all the jumping variables
    [System.Serializable]
    public class JumpVar
    {
        public float strength = 30f;
    }

    private JumpVar jump;
    private Rigidbody rb;

    public float jumpTimeCounter;
    public float jumpTime;
    public bool isJumping;

    private void Start()
    {
        jump = new JumpVar();
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        if (player.isGrounded && PI.isJumpKeyDown)
        {
            Debug.Log("Player Tryin to jump");
            isJumping = true;
            jumpTimeCounter = jumpTime;
            rb.velocity = Vector3.up * jump.strength;
        }
        if (PI.isJumpKeyHeld && isJumping)
        {
            if (jumpTimeCounter > 0)
            {
                rb.velocity = Vector3.up * jump.strength;
                jumpTimeCounter -= Time.deltaTime;
            }
            else
            {
                isJumping = false;
            }
        }

        if (PI.isJumpKeyReleased)
        {
            Debug.Log("Player released jump");
            isJumping = false;
        }
    }

    // HELPERS
    private PlayerInputs PI
    {
        get
        {
            return GetComponent<PlayerInputs>();
        }
    }

    private Player player
    {
        get
        {
            return GetComponent<Player>();
        }
    }
}
