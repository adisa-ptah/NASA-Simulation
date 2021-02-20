using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizontalInput;
    public float xRange = 22.0f;
    public float playerSpeed = 15.0f;
    // public float fireFood;


    // When you put game object you have to attach somehthing to it.
    // Just like  to follow a player on the camera, you attach the player to it
    // Here we attach the food to the player since thats its origin
    public GameObject projectilePrefab;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // The if statement bounds our player, If it goes too far to the left, limit him
        // By creating a new positon where the object stays at the max x range and at what ever
        // the previous y and z positon were.
        // Basically, if the player passes the imaginary wall, snap him back to the limit,
        // Thats why you see a bounce on the game

        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
        else if (transform.position.x > xRange)
        {
            transform.position = new Vector3(+xRange, transform.position.y, transform.position.z);
        }

        // We use these already set up from Unity to control our player
        // Translate our player to the "right" at a constant time with player speed and arrow detection
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * Time.deltaTime * playerSpeed * horizontalInput);

        // Also already from unity, if a button is pushed down, an action is performed, here we
        // Intantiate a food object and clones, from where the player is, and give it good rotation
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Launch a projectile from the player.
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
        }

        //fireFood = Input.GetAxis("Fire");
        //transform.Translate(Vector3.forward * Time.deltaTime * playerSpeed * fireFood);
    }
}
