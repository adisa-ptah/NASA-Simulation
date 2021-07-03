using MLAPI;
using MLAPI.Messaging;
using MLAPI.NetworkVariable;
using UnityEngine;

public class RobotSpawner : NetworkBehaviour
{

    public GameObject robotPrefab;
    public int noOfSpareRobots;

    /*
    public void OnStartServer()
    {
        spawnRobots(noOfSpareRobots);
        GetComponent<NetworkObject>().enabled = true;
        

    }
     

    public override void NetworkStart()
    {
        spawnRobots(noOfSpareRobots);
        GetComponent<NetworkObject>().enabled = true;
        //NetworkServer.Spawn(robot);
        base.NetworkStart();
    }

     */

    void Start()
    {
        spawnRobots(noOfSpareRobots);
        GetComponent<NetworkObject>().enabled = true;
        //NetworkServer.Spawn();
    }
   



    void spawnRobots(int noOfSpareRobots)
   {
        for (int i = 0; i < noOfSpareRobots; i++)
        {
            Vector3 spawnPosition = new Vector3(Random.Range(-20, 5f), 0.5f, Random.Range(-12, 5f));
            Quaternion spawnRotation = Quaternion.Euler(0, 0, 0);

            GameObject robot = (GameObject)Instantiate(robotPrefab, spawnPosition, spawnRotation);
           

        }
    }
}


//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public class SpawnManager : MonoBehaviour
//{
//    public GameObject enemyPrefab;
//    public GameObject powerUpPrefab;
//    private float spawnRange = 9;
//    public int enemyCount;
//    public int waveNumber = 1;

//    // Start is called before the first frame update
//    void Start()
//    {
//        spawnEnemyWave(enemyCount);

//    }

//    // Update is called once per frame
//    void Update()
//    {
//        enemyCount = FindObjectsOfType<Enemy>().Length;

//        if(enemyCount == 0)
//        {
//            waveNumber++;
//            spawnEnemyWave(waveNumber);
//            Instantiate(powerUpPrefab, generateSpawnPosition(), powerUpPrefab.transform.rotation);
//        }
//    }

//    void spawnEnemyWave(int enemiestoSpawn)
//    {
//        for (int i = 0; i < enemiestoSpawn - 1; i++)
//        {
//            Instantiate(enemyPrefab, generateSpawnPosition(), enemyPrefab.transform.rotation);
//        }
//    }

//    private Vector3 generateSpawnPosition()
//    {
//        float spawnPosition = Random.Range(-spawnRange, spawnRange);
//        Vector3 randomPosition = new Vector3(spawnPosition, 0, spawnPosition);

//        return randomPosition;


//    }
//}