using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public delegate void StartPreparation(int a);
public class GameLogic
{

    private GameStateMachine gsm;
    public GameLogic()
    {
        this.gsm = new GameStateMachine();
    }

    public void Excecute()
    {
        this.gsm.Update();
    }

    public void Prepare()
    {
        gsm.ChangeState(new State_Prepare(new StartPreparation(this.StartPrepare)));
    }
    public void Play()
    {
        gsm.ChangeState(new State_Play());
    }
    public void End()
    {
        gsm.ChangeState(new State_EndGame());
    }

    public void StartPrepare(int counter)
    {
        Debug.Log("Counter CCCC " + counter);
    }
}
