using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputController : ZeltController
{
    public InputController()
    {
        this.controllerName = Constants.ControllerName.InputController;
    }

    public KeyCode jumpKey
    {
        get
        {
            return KeyCode.Space;
        }
    }
}
