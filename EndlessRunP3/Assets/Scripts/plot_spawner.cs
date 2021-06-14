using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class plot_spawner : MonoBehaviour
{
    private int amount = 8;
    private float plotSize = 60f;
    private float xPosLeft = -50.6f;
    private float xPosRight = 50.6f;
    private float lastZPosLeft = 15f;
    //private float lastZPosRight = 15f;

    public List<GameObject> plots;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < amount; i++)
        {
            SpawnPlot();
        }
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void SpawnPlot()
    {
        GameObject plotLeft = plots[Random.Range(0, plots.Count)];
        GameObject plotRight = plots[Random.Range(0, plots.Count)];
        float zPosLeft = lastZPosLeft + plotSize;
        //float zPosRight = lastZPosRight + plotSize;

        Instantiate(plotLeft, new Vector3(xPosLeft, 1.5f, zPosLeft), plotLeft.transform.rotation);
        Instantiate(plotRight, new Vector3(xPosRight, 1.5f, zPosLeft), new Quaternion(0,180,0,0));

        lastZPosLeft += plotSize;
        //lastZPosRight += plotSize;
    }
}
