using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerX : MonoBehaviour
{
    public GameObject[] ballPrefabs;

    private float spawnLimitXLeft = -22;
    private float spawnLimitXRight = 7;
    private float spawnPosY = 30;

    public float timer;

    private float minTime = 1.5f;
    private float maxTime = 6.0f;

    public float spawnTimeInterval;

    // Start is called before the first frame update
    void Start()
    {
        spawnTimeInterval = Random.Range(minTime, maxTime);
       
    }

    void Update()
    {
        timer += Time.deltaTime;
        // Spawn random ball at random x position at top of play area
        if (timer > spawnTimeInterval)
        {
            //cal function
            SpawnRandomBall();
            //reset timer and spawn interval
            spawnTimeInterval = Random.Range(minTime, maxTime);
            timer = 0;

        }
    }

void SpawnRandomBall()
    {
        // Generate random ball index and random spawn position
        Vector3 spawnPos = new Vector3(Random.Range(spawnLimitXLeft, spawnLimitXRight), spawnPosY, 0);
        int ballIndex = Random.Range(0, ballPrefabs.Length);
        // instantiate ball at random spawn location
        Instantiate(ballPrefabs[ballIndex], spawnPos, ballPrefabs[ballIndex].transform.rotation);
    }

}
