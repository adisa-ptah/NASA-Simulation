using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoor : MonoBehaviour { 

    public Animation hingehere;

    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    // Code below is to trigger animation of door. Press "Space" once trigger is picked up to begin animation. 
    void OnTriggerStay () {
        if (Input.GetKey (KeyCode.Space))
            hingehere.Play();
    }
}
