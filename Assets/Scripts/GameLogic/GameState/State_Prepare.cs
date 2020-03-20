using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class State_Prepare : IState
{
    private StartPreparation prepa;

    public State_Prepare(StartPreparation prep)
    {
        prepa = prep;
    }

    public void Enter()
    {
        Debug.Log("STATE PREPAREGAME - ENTER");
        this.prepa(1);
    }

    public void Execute()
    {

    }

    public void Exit()
    {
        Debug.Log("STATE PREPAREGAME - END");
    }
}

