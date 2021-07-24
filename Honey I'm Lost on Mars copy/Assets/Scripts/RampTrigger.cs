using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RampTrigger : MonoBehaviour
{

    public Component ramphere;
    public GameObject keygone;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void OnTriggerStay()
    {
        // Code to pickup the ramp trigger. Press "Q" to pickup the block. 
        if (Input.GetKey(KeyCode.Q))
            ramphere.GetComponent<BoxCollider>().enabled = true;


        if (Input.GetKey(KeyCode.Q))
            keygone.SetActive(false);

    }
}
