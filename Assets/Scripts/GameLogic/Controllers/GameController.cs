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

    private void Awake()
    {
        this.environmentController = new EnvironmentController(this.playerPrefab);
        this.inputController = new InputController();
        Debug.Log("Game Controller Initialized!\n----------------------------");

    }

    private void Start()
    {
        StartGame();
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
