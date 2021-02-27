using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBoundsX : MonoBehaviour
{
    private float leftLimit = -50;
    private float bottomLimit = -1;


    // Update is called once per frame
    void Update()
    {
        // Destroy dogs if z position less than left limit
        if (transform.position.x < leftLimit)
        {
            Destroy(gameObject);
        } 
        // Destroy balls if y position is less than bottomLimit
        else if (transform.position.y < bottomLimit)
        {
            // Code to depict losing message if an object reaches the bottom of the screen. 
            Debug.Log("YOU LOSE!");
            Destroy(gameObject);
        }

    }
        }
 
