/*
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HubSwapPlayer : MonoBehaviour
*/
using System;
using MLAPI;
using UnityEngine;

public class HubSwapPlayer : NetworkBehaviour
{
    public Hub hub;


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            hub.ChangePlayer(this.gameObject);
            GetComponent<PlayerControl>().enabled = true;
            GetComponent<NetworkObject>().enabled = true;

        }
    }

    void OnMouseDown()
    {
        hub.ChangePlayer(this.gameObject);
        GetComponent<PlayerControl>().enabled = true;
        this.GetComponent<PlayerCamFollow>().enabled = true;

        //GameObject.Find("Camera").GetComponent<PlayerCamFollow>().enabled = true;
    }

}



