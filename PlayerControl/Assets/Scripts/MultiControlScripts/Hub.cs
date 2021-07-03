/*
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hub : MonoBehaviour
*/

using System;
using MLAPI;
using UnityEngine;

public class Hub : NetworkBehaviour
{

    public GameObject[] Players;
    [SerializeField]

    GameObject CurrentPlayer;
    public Hub hub;

    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0; i < Players.Length; i++)
        {
            Players[i].GetComponent<PlayerControl>().enabled = false;
            this.Players[i].GetComponent<PlayerCamFollow>().enabled = false;
        }
        CurrentPlayer = Players[0];
    }

    public void ChangePlayer(GameObject player)
    {
        CurrentPlayer.GetComponent<PlayerControl>().enabled = false;
        this.CurrentPlayer.GetComponent<PlayerCamFollow>().enabled = false;
        CurrentPlayer = player;

        //CurrentPlayer.GetComponent<PlayerCamFollow>().enabled = false;
        //GameObject.Find("Camera").GetComponent<PlayerCamFollow>().enabled = false;

    }


}
