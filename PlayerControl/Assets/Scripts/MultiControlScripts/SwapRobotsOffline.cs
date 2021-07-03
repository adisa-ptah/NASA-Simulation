using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwapRobotsOffline : MonoBehaviour
{

    public GameObject[] Players;
    GameObject currentPlayer;
    int playerIndex;

    void Start()
    {
        playerIndex = 0;
        currentPlayer = Players[0];
    }

    // Update is called once per frame
    void Update()
    {
           if (Input.GetKeyDown(KeyCode.Space))
           {
            playerIndex++;
                if(playerIndex == Players.Length) {
                playerIndex = 0;
                }
           }

        currentPlayer.GetComponent<PlayerControl>().enabled = false;
        Players[playerIndex].GetComponent<PlayerControl>().enabled = true;
        //GameObject.Find("Camera").GetComponent<AutoCam>.myTarget = Players[playerIndex].transform;
        GameObject.Find("Camera").GetComponent <PlayerCamFollow>().enabled = true;
        currentPlayer = Players[playerIndex];
    }

    
}
