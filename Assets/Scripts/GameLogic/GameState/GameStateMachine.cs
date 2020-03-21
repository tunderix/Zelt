
using UnityEngine;
using UnityEditor;

public class GameStateMachine
{
    protected GameState currentState;

    public void ChangeState(GameState newState)
    {
        if (currentState != null)
            currentState.OnExit();

        currentState = newState;
        currentState.OnEnter();
    }

    public void Update()
    {
        if (currentState != null) currentState.OnExcecute();
    }
}
