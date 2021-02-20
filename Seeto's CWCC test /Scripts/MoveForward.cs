using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// We apply this to every GameObject that needs to move forward, so the animals and the food.

public class MoveForward : MonoBehaviour
{
    // Default speed set here, the speed is different for each object.
    public float speed = 40;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // To translate the game object "forward" at a constant time.
        transform.Translate(Vector3.forward * Time.deltaTime * speed);

    }
}
