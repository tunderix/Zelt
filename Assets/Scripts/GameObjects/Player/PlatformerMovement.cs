using UnityEngine;

[RequireComponent(typeof(Player), typeof(PlayerInputs))]
public class PlatformerMovement : ZeltBehaviour
{

    // Holds all the movement variables
    [System.Serializable]
    public class Movement
    {
        public float moveSpeed = 60.0f;
        public InputDirection lastInputDirection = InputDirection.None;
    }

    // Variables
    private Rigidbody rb;
    private Rigidbody2D rb2d;
    public Movement movement;
    Vector2 moveVelocity;

    // Does this script currently respond to Input?
    public bool canControl = true;

    private void Start()
    {

        rb = GetComponent<Player>().PlayerRigidbody;
        moveVelocity = new Vector2(0, 0);
        movement = new Movement();
    }

    private void Update()
    {
        ResetVelocity();
        UpdateHorizontalVelocity();
        UpdateLastInput();
    }

    private void FixedUpdate()
    {
        ApplyMovement();
    }

    private void ResetVelocity()
    {
        moveVelocity.x = 0f;
        moveVelocity.y = -0f;
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

    // X axis is disabled//locked, Only update movement in terms of Y and Z
    // Y = Vertical
    // Z = Horizontal
    void ApplyMovement()
    {
        Vector3 movementVector = new Vector3(horizontalVelocity, rb.velocity.y, 0);
        rb.MovePosition(transform.position + (movementVector * Time.deltaTime));
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