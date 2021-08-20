using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickKey : MonoBehaviour {

    public Component doorcolliderhere;
    public GameObject keygone;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void OnTriggerStay () {
        // Code to configure pick-up key on keyboard. Press "Space" to pickup key trigger. 
        if (Input.GetKey(KeyCode.Space))
            doorcolliderhere.GetComponent<BoxCollider> ().enabled = true;
        
        
        if (Input.GetKey(KeyCode.Space))
        keygone.SetActive(false); 

    }
}
