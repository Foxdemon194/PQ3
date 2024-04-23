using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PrincessEncounter : MonoBehaviour
{
    public PlayerScript playerScript;
    public playerInventory playerInventory;

    public GameObject VicotryScreen;
    public GameObject NotEnoughItems;

    public Text PrincessText;

    private void Start()
    {
        playerInventory = GetComponent<playerInventory>();
        playerScript = GetComponent<PlayerScript>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Princess") && playerScript.movementLeft == 0)
        {
            CheckForWinner();
        }
    }

    void CheckForWinner()
    {
        if(playerInventory.totalItems >= 4)
        {
            if (playerInventory.isPlayer2)
            {
                //this player won
                //disable the other player
                VicotryScreen.SetActive(true);
                PrincessText.text = "Thank you for collecting my stuff blue Knight!";
            }
            else
            {
                //this player won
                //disable the other player
                VicotryScreen.SetActive(true);
                PrincessText.text = "Thank you for collecting my stuff Red Knight!";
            }

        }
        else if (playerInventory.hasHorns)
        {
            if (playerInventory.isPlayer2)
            {
                //this player won
                //disable the other player
                VicotryScreen.SetActive(true);
                PrincessText.text = "Thank you for defeating the minotaur Blue Knight!";
            }
            else
            {
                //this player won
                //disable the other player
                VicotryScreen.SetActive(true);
                PrincessText.text = "Thank you for defeating the minotaur Red Knight!";
            }

        }
        else
        {
            NotEnoughItems.SetActive(true);
            //display to fuck off.
        }
    }

    public void ContinuePlaying()
    {
        NotEnoughItems.SetActive(false);
    }
    
}
