using UnityEngine;

[RequireComponent(typeof(Player), typeof(PlayerInputs))]
public class PlatformerMovement : ZeltBehaviour
{

    // Holds all the movement variables
    [System.Serializable]
    public class Movement
    {
        public float moveSpeed = 80.0f;
        public InputDirection lastInputDirection = InputDirection.None;
    }

    // Holds all the jumping variables
    [System.Serializable]
    public class Jumping
    {
        public float strength = 50f;
        public bool doubleJumping = false;
        public bool canDoubleJump = false;
        public float doubleJumpStrength = 0.2f;

        // Last time the jump button was clicked down
        [System.NonSerialized]
        public float lastButtonTime = -10.0f;

        // Time we started a jump
        [System.NonSerialized]
        public float lastTime = -1.0f;

        // Mid air start height for double jump
        [System.NonSerialized]
        public float lastStartHeight = 0.0f;
    }

    // Variables
    private Rigidbody rb;
    private Rigidbody2D rb2d;
    public Movement movement;
    public Jumping jumping;
    Vector2 moveVelocity;

    // Does this script currently respond to Input?
    public bool canControl = true;

    private void Start()
    {

        rb = GetComponent<Player>().PlayerRigidbody;
        moveVelocity = new Vector2(0, 0);
        jumping = new Jumping();
        movement = new Movement();
    }

    private void Update()
    {
        ResetVelocity();
        UpdateHorizontalVelocity();
        UpdateLastInput();

        // Vertical Movement
        /*if (PI.isJumpKeyDown && player.isGrounded)
            Jump();
        else if (PI.isJumpKeyDown && jumping.canDoubleJump)
            Jump();
*/
        ApplyMovement();
    }

    private void ResetVelocity()
    {
        moveVelocity.x = 0f;
        moveVelocity.y = -0.1f;
    }

    private void UpdateLastInput()
    {
        if (PI.keyUp == InputDirection.Right || PI.keyUp == InputDirection.Left)
        {
            movement.lastInputDirection = PI.keyUp;
        }
    }

    private void UpdateHorizontalVelocity()
    {
        // Horizontal movement
        moveVelocity.x = PI.keyDown == InputDirection.Right ? movement.moveSpeed : moveVelocity.x;
        moveVelocity.x = PI.keyDown == InputDirection.Left ? -movement.moveSpeed : moveVelocity.x;
    }

    private void Jump()
    {
        //Double jumping
        if (!player.isGrounded)
        {
            jumping.doubleJumping = true;
            jumping.canDoubleJump = false;
        }

        moveVelocity.y += jumping.doubleJumping ? jumping.strength + jumping.doubleJumpStrength : jumping.strength;
    }

    // X axis is disabled//locked, Only update movement in terms of Y and Z
    // Y = Vertical
    // Z = Horizontal
    void ApplyMovement()
    {
        Vector3 movementVector = new Vector3(horizontalVelocity, rb.velocity.y, 0);
        rb.velocity = movementVector;
    }

    // Velocity combining Walking and Jumping
    float horizontalVelocity
    {
        get { return moveVelocity.x; }
    }

    float jumpVelocity
    {
        get { return rb.velocity.y + moveVelocity.y; }
    }


    //
    // Collisions
    //

    void OnCollisionEnter(Collision other)
    {
        jumping.canDoubleJump = true;
        jumping.doubleJumping = false;
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