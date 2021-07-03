using MLAPI;
using MLAPI.Spawning;
using UnityEngine;



public class DroneSpawner : NetworkBehaviour
{
    public GameObject robotPrefab;
    public int noOfSpareRobots;



    public override void NetworkStart()
    {
        //spawnRobots(noOfSpareRobots);
        for (int i = 0; i <= noOfSpareRobots; i++)
        {
            Vector3 spawnPosition = new Vector3(Random.Range(-20, 5f), 0.5f, Random.Range(-12, 5f));
            GameObject robot = Instantiate(robotPrefab, spawnPosition, Quaternion.identity);
            robot.GetComponent<NetworkObject>().Spawn();

        }

    }

}
