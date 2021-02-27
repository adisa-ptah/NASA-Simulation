using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    public float timer = 2.0f;
    public float waitTime = 2.0f;

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        // On spacebar press, send dog if timer larger then waitTime (1.0)
        if (Input.GetKeyDown(KeyCode.Space) & timer > waitTime)
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            timer = 0.0f; // reset timer
        }
    }
}
