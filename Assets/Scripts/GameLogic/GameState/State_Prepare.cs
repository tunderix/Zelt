using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class State_Prepare : IState
{

    public State_Prepare() { }

    public void Enter()
    {
        Debug.Log("STATE PREPAREGAME - ENTER");
    }

    public void Execute()
    {

    }

    public void Exit()
    {
        Debug.Log("STATE PREPAREGAME - END");
    }
}

