using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class State_EndGame : IState
{

    public State_EndGame() { }

    public void Enter()
    {
        Debug.Log("STATE ENDGAME - ENTER");
    }

    public void Execute()
    {

    }

    public void Exit()
    {
        Debug.Log("STATE ENDGAME - END");
    }
}
