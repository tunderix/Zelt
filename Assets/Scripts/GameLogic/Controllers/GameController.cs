using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : ZeltBehaviour
{
    private InputController inputController;

    private void Awake()
    {
        this.inputController = new InputController();
        Debug.Log("Game Controller Initialized!\n----------------------------");
    }

    // TODO - Input controller
    public InputController InputController
    {
        get
        {
            return this.inputController;
        }
    }

    // TODO - Sound Controller

    // TODO - Storage Controller

    // TODO - Environment/Map Controller

    // TODO - Enemy Engine
}
