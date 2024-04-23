using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GiantSpiderEvent : MonoBehaviour
{
    private PlayerHealth playerHealth;
    private PlayerScript playerScript;

    private int dieRoll;

    public Text spiderText;
    public GameObject continueButton;
    public GameObject rollDieButton;
    public GameObject SpiderEncounter;
    public GameObject Background;
    private bool enemyDied;


    public void GiantSpiderRollDie()
    {
        rollDieButton.SetActive(false);
        continueButton.SetActive(true);
        dieRoll = Random.Range(1, 7);

        Debug.Log(dieRoll);


        if (dieRoll == 6)
        {
            spiderText.text = "Spider Killed you!";
            playerHealth.gameOver = true;
        }
        else if (dieRoll == 5)
        {
            spiderText.text = "The spider bit you. lose an token";
            playerHealth.isPoisoned = true;


        }
        else
        {
            // text to say that zombie died
            spiderText.text = "You've defeated the Spider";
            enemyDied = true;
        }
    }


    public void ContinueGame()
    {   
        spiderText.text = "A Giant Enemy Spider!";
        Background.SetActive(false);
        SpiderEncounter.SetActive(false);
        playerHealth = null;
        playerScript = null;
        
        if (enemyDied)
        {
            Destroy(gameObject);
        }

    }

    public void Destoyobject()
    {
        Destroy(gameObject);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerScript = other.GetComponent<PlayerScript>();

            if (playerScript.movementLeft == 0)
            {
                playerHealth = other.GetComponent<PlayerHealth>();
            }
            else
            {
                playerHealth = null;
            }

        }
    }

}
