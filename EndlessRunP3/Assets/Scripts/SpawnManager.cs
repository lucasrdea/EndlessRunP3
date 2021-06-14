using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    RoadSpawner roadSpawner;
    plot_spawner plotSpawner;
    // Start is called before the first frame update
    void Start()
    {
        roadSpawner = GetComponent<RoadSpawner>();
        plotSpawner = GetComponent<plot_spawner>();
    }

    public void SpawnTriggerEntered()
    {
        roadSpawner.MoveRoad();
        plotSpawner.SpawnPlot();
    }
}
