using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class GameState
{
    public virtual bool OnEnter()
    {
        Debug.Log("STATE ENTERED");
        return true;
    }
    public abstract bool OnExcecute();
    public virtual bool OnExit()
    {
        Debug.Log("STATE ENDED");
        return true;
    }
}
