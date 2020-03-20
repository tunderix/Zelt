using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnvironmentController : ZeltController
{
    private GameObject player;

    public EnvironmentController(GameObject playerPrefab)
    {
        this.controllerName = Constants.ControllerName.EnvironmentController;
        this.player = playerPrefab;
    }

    public void SpawnPlayer(SpawnRandomizer spawnArea)
    {
        GameObject.Instantiate(this.player, spawnArea.RandomSpawn, this.player.transform.rotation);
    }
}
