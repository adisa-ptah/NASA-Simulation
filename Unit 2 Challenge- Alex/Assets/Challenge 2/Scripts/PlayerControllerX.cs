using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    private float fireRate = 1; // Time setting until player can send another dog. 
    private float nextFire = 0; // Time until the player can fire the first dog. 

    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog if interval period has passed between dogs. 
        if (Input.GetKeyDown(KeyCode.Space) && Time.time > nextFire)
        {
            nextFire = Time.time + fireRate; // reset nextFire to current time + fireRate
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
        }
    }
}
