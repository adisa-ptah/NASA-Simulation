using System;
using MLAPI;
using UnityEngine;

public class PlayerController : NetworkBehaviour
{
    //private variables
    private float speed = 5.5f;
    private float turnSpeed = 25.0f;
    private float horizontalInput;
    private float forwardInput;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");

        // We move the vehicle forward
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        // We turn the vehicle forward
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput);
    }

}
