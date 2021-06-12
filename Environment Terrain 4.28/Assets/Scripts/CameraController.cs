using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class CameraController : MonoBehaviour

{

    public GameObject player;        //Public variable to store a reference to the player game object


    public Vector3 offset;            //Private variable to store the offset distance between the player and camera

    // Use this for initialization
    void Start()
    {
        //Calculate and store the offset value by getting the distance between the player's position and camera's position.
        offset = transform.position - player.transform.position;
    }

    // LateUpdate is called after Update each frame
    void LateUpdate()
    {
        // Set the position of the camera's transform to be the same as the player's, but offset by the calculated offset distance.
        transform.position = player.transform.position + offset;
    }
}


/*
{

    // Start is called before the first frame update
    void Start()
    {

        // Third person Camera
        Camera.main.transform.position = this.transform.position - this.transform.forward * 45 + this.transform.up * 30;
        //Camera.main.transform.LookAt(this.transform.position);
        Camera.main.transform.parent = this.transform;

        // First person Camera
        //Camera.main.transform.position = this.transform.position - this.transform.forward * -1.0f + this.transform.up * 1.0f; 


    }

    // Update is called once per frame
    void Update()
    {

    }

}
*/



