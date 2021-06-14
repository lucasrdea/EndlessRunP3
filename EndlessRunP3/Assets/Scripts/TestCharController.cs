using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestCharController : MonoBehaviour
{
    public float movimentSpeed = 10f;
    public SpawnManager spawnManager;
    // Start is called before the first frame update
    void Start()
    {
        //spawnManager = GetComponent<SpawnManager>();
    }

    // Update is called once per frame
    void Update()
    {
        float hMovement = Input.GetAxis("Horizontal") * movimentSpeed / 2;
        float vMovement = Input.GetAxis("Vertical") * movimentSpeed;
        transform.Translate(new Vector3(hMovement, 0, vMovement));
    }
    public void OnTriggerEnter(Collider other)
    {
        spawnManager.SpawnTriggerEntered();
    }
}
