using System;
using MLAPI;
using UnityEngine;

public class PlayerCamFollow : NetworkBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        //if (IsLocalPlayer)
        {
            Camera.main.transform.position = this.transform.position - this.transform.forward * 5 + this.transform.up * 3;
            Camera.main.transform.LookAt(this.transform.position);
            Camera.main.transform.parent = this.transform;
        }

    }

    // Update is called once per frame
    void Update()
    {

        Camera.main.transform.position = this.transform.position - this.transform.forward * 5 + this.transform.up * 3;
        Camera.main.transform.LookAt(transform.position);
        //Camera.main.transform.parent = this.transform;



    }

}