using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class SpawnManager : MonoBehaviour
{
    public GameObject[] balloonPrefabs;
    public float startDelay = 0.5f;
    public float spawnInterval = 1.5f;
    public float xRange = 10.0f;
    public float yPos = -10.0f;
    void Start()
    {
        InvokeRepeating("SpawnRandomBalloon", startDelay, spawnInterval); 
    }
    void SpawnRandomBalloon()
    {
        //Get a random position on the x-axis
        Vector3 spawnPos = new Vector3(Random.Range(-xRange, xRange), 7.5f, 0);
        // Pick a random balloon from the balloon array
        int balloonIndex = Random.Range(0, balloonPrefabs.Length);
        // Spawn random baloon at the spawn point
        Instantiate(balloonPrefabs[balloonIndex], spawnPos, balloonPrefabs[balloonIndex].transform.rotation);

    }

}
