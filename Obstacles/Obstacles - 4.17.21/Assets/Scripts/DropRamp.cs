using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropRamp : MonoBehaviour
{

    public Animation ramphere;



    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void OnTriggerStay()
    {
        // Code to engage ramp-drop animation. Press "Q" after picking up trigger to engage animation. 
        if (Input.GetKey(KeyCode.Q))
            ramphere.Play();
    }
}

