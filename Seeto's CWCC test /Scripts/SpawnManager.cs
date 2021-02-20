using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Code for the spawning of random animals. Applied only to animals.

public class SpawnManager : MonoBehaviour
{
    // Prefabs are dublicate copies we create a prefab folder on unity and make
    // copies of items that would be respawning.

    public GameObject[] animalPrefabs;
    public float spawnRangeX = 22.0f;    // Range animals can spread out in the X-axis
    public float spawnPositionZ = 35.0f; // Where animals spawn on Z-axis
    private float startDelay = 2.0f;     // Time delay for first spawn after game starts
    private float spawnInterval = 3.0f;  // How often spawn repeats 


    // Start is called before the first frame update
    // We are here becuase we want something to happen as soon as the game "Starts"
    void Start()
    {
        // From C# that requires method name and two time constraints
        // Call SpawnRandomAnimal after 2 seconds then repeat spawn 3 seconnds after that.
        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval);

    }

    // Update is called once per frame
    void Update()
    {

    }

    // Spawn a random animal
    void SpawnRandomAnimal()
    {
        // Since our animalPrefab is an array we randomly pick an animal ranging from index 0-2. (0,1,2)
        int animalIndex = Random.Range(0, animalPrefabs.Length);

        // Animals spawn at the vector3 position with an X range ans set y and z value
        Vector3 spawnPosition = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPositionZ);

        // The spawning occurs: It chooses a random animal, at our above spawn posiiton, and picks the correct rotaion 
        // For subsequent clones so they are not facing the wrong way 
        Instantiate(animalPrefabs[animalIndex], spawnPosition, animalPrefabs[animalIndex].transform.rotation);


    }
}
