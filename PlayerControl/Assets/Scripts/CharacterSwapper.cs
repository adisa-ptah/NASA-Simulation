using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterSwapper : MonoBehaviour
{
    //Not online

    public Transform character;
    public List<Transform> possibleCharacters;
    public int whichCharacter;

    // Start is called before the first frame update
    void Start()
    {
        if (character == null && possibleCharacters.Count >= 1)
        {
            character = possibleCharacters[0];
        }
        Swap();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (whichCharacter == 0)
            {
                whichCharacter = possibleCharacters.Count - 1;
            }
            else
            {
                whichCharacter -= 1;
            }
            Swap();
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            if (whichCharacter == possibleCharacters.Count - 1)
            {
                whichCharacter = 0;
            }
            else
            {
                whichCharacter += 1;
            }
            Swap();
        }
    }

    public void Swap()
    {
        character = possibleCharacters[whichCharacter];
        character.GetComponent<PlayerControl>().enabled = true;
        character.GetComponent<PlayerCamFollow>().enabled = true;

        for (int i = 0; i < possibleCharacters.Count; i++)
        {
            if (possibleCharacters[i] != character)
            {
                possibleCharacters[i].GetComponent<PlayerControl>().enabled = false;
                possibleCharacters[i].GetComponent<PlayerCamFollow>().enabled = false;

            }
        }
    }
}
