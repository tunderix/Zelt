using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class State_Prepare : GameState
{
    private StartPreparation prepa;

    public State_Prepare(StartPreparation prep)
    {
        prepa = prep;
    }

    public override bool OnEnter()
    {
        Debug.Log("STATE PREPAREGAME - ENTER");
        this.prepa(1);
        return true;
    }

    public override bool OnExcecute()
    {
        return false;
    }
}

