using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// We would use this for ever object that should collide, so the food with the animals
// This is in combination with Box Collision on our prefab so we essentially know the "hit box"
// To use box collison we need our object to be a rigid body so make sure to add that component too.

public class DetectCollisions : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    // A method we got from C#. On trigger meaning On contact between game objects...
    private void OnTriggerEnter(Collider other)
    {
        // Destroy game object. Because it is already applied to both food and animals, both
        // game objects dissapper.
        // If It was only applied to the food and we wanted only the animal to get destroyed, we would
        // use Destroy(other.gameObject);

        Destroy(gameObject);



    }
}
