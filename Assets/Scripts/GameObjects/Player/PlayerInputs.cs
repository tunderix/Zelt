using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//
// Input Detection
//
public enum InputDirection
{
    None,
    Left,
    Right
}

public class PlayerInputs : ZeltBehaviour
{

    public InputDirection keyDown
    {
        get
        {
            if (rightKeyDown)
                return InputDirection.Right;
            if (leftKeyDown)
                return InputDirection.Left;
            return InputDirection.None;
        }
    }

    public InputDirection keyUp
    {
        get
        {
            if (rightKeyUp)
                return InputDirection.Right;
            if (leftKeyUp)
                return InputDirection.Left;
            return InputDirection.None;
        }
    }

    public bool isJumpKeyDown
    {
        get { return Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.Z) || Input.GetKeyDown(KeyCode.W); }
    }

    public bool isJumpKeyHeld
    {
        get { return Input.GetKey(KeyCode.Space) || Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.Z) || Input.GetKey(KeyCode.W); }
    }

    public bool isJumpKeyReleased
    {
        get { return Input.GetKeyUp(KeyCode.Space) || Input.GetKeyUp(KeyCode.UpArrow) || Input.GetKeyUp(KeyCode.Z) || Input.GetKeyUp(KeyCode.W); }
    }

    public bool leftKeyDown
    {
        get { return Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A); }
    }

    public bool rightKeyDown
    {
        get
        {
            return Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D);
        }
    }

    public bool leftKeyUp
    {
        get { return Input.GetKeyUp(KeyCode.LeftArrow) || Input.GetKeyUp(KeyCode.A); }
    }

    public bool rightKeyUp
    {
        get
        {
            return Input.GetKeyUp(KeyCode.RightArrow) || Input.GetKeyUp(KeyCode.D);
        }
    }
}
