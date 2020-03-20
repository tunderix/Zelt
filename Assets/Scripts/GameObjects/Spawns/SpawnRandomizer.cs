using UnityEngine;

public class SpawnRandomizer : ZeltBehaviour
{
    private Transform[] spawnAreas;

    private void Awake()
    {
        this.spawnAreas = this.GetComponentsInChildren<Transform>();
    }

    public Vector3 RandomSpawn
    {
        get
        {
            return this.randomPointInsideAreas();
        }
    }

    private Vector3 randomPointInsideAreas()
    {
        //Take a random spawn area
        Transform randomArea = spawnAreas[Random.Range(0, spawnAreas.Length)];

        // Take a random point inside chosen area
        return randomPointInsideGameobject(randomArea);
    }

    private Vector3 randomPointInsideGameobject(Transform spawnArea)
    {
        Vector3 rndPosWithin;
        rndPosWithin = new Vector3(Random.Range(-1f, 1f), Random.Range(-1f, 1f), Random.Range(-1f, 1f));
        rndPosWithin = spawnArea.TransformPoint(rndPosWithin * .5f);
        return rndPosWithin;
    }
}
