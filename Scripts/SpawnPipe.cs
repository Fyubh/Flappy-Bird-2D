using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPipe : MonoBehaviour
{
    [SerializeField] private GameObject pipe;
    [SerializeField] private float spawnDelay = 0f, spawnInterval = 1.5f;
    private PlayerController playerControllerScript;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnObjects", spawnDelay, spawnInterval);
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    void SpawnObjects()
    {
        // Set random spawn location and random object index
        Vector2 spawnLocation = new Vector2(20, Random.Range(-0.74f, 1.96f));

        // If game is still active, spawn new object
        if (!playerControllerScript.isGameOver)
        {
            Instantiate(pipe, spawnLocation, pipe.transform.rotation);
        }
    }
}
