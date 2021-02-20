using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    public float timer;

    // Update is called once per frame
    void Update()
    {
        // Creates a timer for the game 
        timer += Time.deltaTime;


        // if we push down space and the timer is more than one, reset the timer and launch a dog
        // if the timer is less than one and we try to "spam" dogs, it doesnt work becuase both conditions
        // have to be met. we have to wait max of one second after sending a dog.

        if (Input.GetKeyDown(KeyCode.Space) && (timer > 1))
            {
            timer = 0;
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);

            
        }
    }
}
