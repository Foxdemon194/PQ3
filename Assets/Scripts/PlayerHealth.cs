using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    EncounterEvent encounterEvent;

    public float health = 20f;
    public bool isPoisoned;
    public bool gameOver;
    public Slider healthSlider;
    public GameObject LoseScreen;
    public Text loseScreenText;
    
    void Start()
    {
        encounterEvent = GetComponent<EncounterEvent>();
    }

    // Update is called once per frame
    void Update()
    {
        healthSlider.value = health;

        if (isPoisoned && encounterEvent.isPlayer2)
        {
            Debug.Log("Player 2 poisoned");
        }
        else if(isPoisoned && encounterEvent.isPlayer2)
        {
            Debug.Log("Player 1 poisoned");
        }

        if (health <= 0)
        {
            gameOver = true;
        }

        if (gameOver)
        {
            LoseScreen.SetActive(true);
            if (encounterEvent.isPlayer2)
            {               
                loseScreenText.text = "GAME OVER" + '\n' + "Player 2 Died";
            }
            else
            {
                loseScreenText.text = "GAME OVER" + '\n' + "Player 1 Died";
            }
        }
    }
}
