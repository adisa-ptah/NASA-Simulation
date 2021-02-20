using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// We apply this to everything that may leave the scene due to its motion
// So applied to animals and food

public class DestroyOutOfBounds : MonoBehaviour
{
    // We form out imaginary walls where the animals cannot go past.
    public float topBound = 35.0f;
    public float bottomBound = -10.0f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // If the object (food) goes past the top bound, it should be destroyed
        if (transform.position.z > topBound)
        {
            Destroy(gameObject);
        }
        else if (transform.position.z < bottomBound)

        // Else if the object (animal) goes past the bottom bound
        {
            // Tells the game is over in the bottom left of the page and destroys the animal
            Debug.Log("Game Over! GG");
            Destroy(gameObject);
        }
    }
}
