using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : ZeltBehaviour
{
    private InputController inputController;
    private EnvironmentController environmentController;

    [Tooltip("Determine where the player spawns by giving quad object")]
    [SerializeField]
    private SpawnRandomizer playerSpawnArea;

    [Tooltip("Game controller needs to know Player Prefab")]
    [SerializeField]
    private GameObject playerPrefab;

    private GameStateMachine gsm;

    private void Awake()
    {
        this.environmentController = new EnvironmentController(this.playerPrefab);
        this.inputController = new InputController();
        this.gsm = new GameStateMachine();
        Debug.Log("Game Controller Initialized!\n----------------------------");

    }

    private void Start()
    {
        gsm.ChangeState(new State_Prepare());
        StartGame();
    }

    private void Update()
    {
        if (Input.GetKeyUp(KeyCode.Z))
        {
            gsm.ChangeState(new State_Play());
        }
        if (Input.GetKeyUp(KeyCode.X))
        {
            gsm.ChangeState(new State_EndGame());
        }
    }

    private void StartGame()
    {
        this.environmentController.SpawnPlayer(playerSpawnArea);
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
