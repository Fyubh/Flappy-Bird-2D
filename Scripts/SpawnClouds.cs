using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnClouds : MonoBehaviour
{
    [SerializeField] private GameObject[] Clouds;
    [SerializeField] private float spawnDelay = 0f, spawnInterval = 1.5f;
    private PlayerController playerControllerScript;
    private int randomCloud;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnObjects", spawnDelay, spawnInterval);
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    void SpawnObjects()
    {
        // Set random spawn location and random object index
        Vector2 spawnLocation = new Vector2(20, 3);
        int index = Random.Range(0, Clouds.Length);

        // If game is still active, spawn new object
        if (!playerControllerScript.isGameOver)
        {
            Instantiate(Clouds[index], spawnLocation, Clouds[index].transform.rotation);
        }
    }
}
