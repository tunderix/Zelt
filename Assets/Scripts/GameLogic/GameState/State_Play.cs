using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class State_Play : IState
{

    public State_Play() { }

    public void Enter()
    {
        Debug.Log("STATE PLAYGAME - ENTER");
    }

    public void Execute()
    {

    }

    public void Exit()
    {
        Debug.Log("STATE PLAYGAME - END");
    }
}

