using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EncounterEvent : MonoBehaviour
{
    public bool isPlayer2;
    public PlayerScript playerScript;
    public PlayerHealth playerHealth;

    //public ZombieEvent zE;
    //public GiantSpiderEvent gSE;

    public Text zombieText;
    public Text minotaurText;
    public Text giantSpiderText;

    public GameObject EncounterBackground;
    public GameObject ZombieSprite;
    public GameObject MinotaurSprite;
    public GameObject SpiderSprite;


    public GameObject zombieRollDieButton;
    public GameObject zombieContinueButton;

    public GameObject zombieRollDieButtonPlayer2;
    public GameObject zombieContinueButtonPlayer2;

    public GameObject minotaurRollDieButton;
    public GameObject minotaurContinueButton;
    public GameObject minotaurRollDieButtonPlayer2;
    public GameObject minotaurContinueButtonPlayer2;

    public GameObject giantSpiderRollDieButton;
    public GameObject giantSpiderContinueButton;
    public GameObject giantSpiderRollDieButtonPlayer2;
    public GameObject giantSpiderContinueButtonPlayer2;


    public MinotaurEncounter minotaurScript;

    private int dieRoll;
    private bool enemyDied;

    public GameObject CurrentMonsterEvent;


    void Start()
    {
       playerScript = GetComponent<PlayerScript>();   
       playerHealth = GetComponent<PlayerHealth>();
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("MinotaurEvent") && playerScript.movementLeft == 0)
        {
            CurrentMonsterEvent = other.gameObject;
            MinotaurEvent();
        }

        if (other.CompareTag("GiantSpiderEvent")  && playerScript.movementLeft == 0 )
        {
            CurrentMonsterEvent = other.gameObject;
            GiantSpiderEvent();
        }
        if (other.CompareTag("ZombieEvent")  && playerScript.movementLeft == 0 )
        {
            
            CurrentMonsterEvent = other.gameObject;
            
            ZombieEvent();        
        }
    }

    

    void MinotaurEvent()
    {
        if (isPlayer2)
        {
            Debug.Log("Player 2 Landed on Minotaur");
            
            //check for magic axe

            EncounterBackground.SetActive(true);
            MinotaurSprite.SetActive(true);
            minotaurRollDieButton.SetActive(false);
            minotaurContinueButton.SetActive(false);
            minotaurRollDieButtonPlayer2.SetActive(true);
            minotaurContinueButtonPlayer2.SetActive(false);
        }
        else
        {
            Debug.Log("Player Landed on Minotaur");

            //check for magic axe

            EncounterBackground.SetActive(true);
            MinotaurSprite.SetActive(true);
            minotaurRollDieButton.SetActive(true);
            minotaurContinueButton.SetActive(false);
            minotaurRollDieButtonPlayer2.SetActive(false);
            minotaurContinueButtonPlayer2.SetActive(false);
        }
    }
    void GiantSpiderEvent()
    {
        if (isPlayer2)
        {
            Debug.Log("Player 2 Landed on Spider");

            EncounterBackground.SetActive(true);
            SpiderSprite.SetActive(true);
            giantSpiderRollDieButton.SetActive(false);
            giantSpiderContinueButton.SetActive(false);
            giantSpiderRollDieButtonPlayer2.SetActive(true);
            giantSpiderContinueButtonPlayer2.SetActive(false);
        }
        else
        {
            Debug.Log("Player Landed on Spider");

            EncounterBackground.SetActive(true);
            SpiderSprite.SetActive(true);
            giantSpiderRollDieButton.SetActive(true);
            giantSpiderContinueButton.SetActive(false);
            giantSpiderRollDieButtonPlayer2.SetActive(false);
            giantSpiderContinueButtonPlayer2.SetActive(false);
        }
    }
    void ZombieEvent()
    {
        if (isPlayer2)
        {
            Debug.Log("Player 2 Landed on Zombie");

            EncounterBackground.SetActive(true);
            ZombieSprite.SetActive(true);
            zombieRollDieButton.SetActive(false);
            zombieContinueButton.SetActive(false);
            zombieRollDieButtonPlayer2.SetActive(true);
            zombieContinueButtonPlayer2.SetActive(false);
        }
        else
        {
            Debug.Log("Player Landed on Zombie");
        
            EncounterBackground.SetActive(true);
            ZombieSprite.SetActive(true);
            zombieRollDieButton.SetActive(true);
            zombieContinueButton.SetActive(false);
            zombieRollDieButtonPlayer2.SetActive(false);
            zombieContinueButtonPlayer2.SetActive(false);
        }
        
             
    }
    public void ZombieRollDie()
    {
        if (isPlayer2)
        {
            zombieRollDieButtonPlayer2.SetActive(false);
            zombieContinueButtonPlayer2.SetActive(true);
        }
        else
        {
            zombieRollDieButton.SetActive(false);
            zombieContinueButton.SetActive(true);
        }

        dieRoll = Random.Range(1, 7);

        Debug.Log(dieRoll);


        if (dieRoll == 1)
        {
            zombieText.text = "Zombie Killed you!";
            playerHealth.gameOver = true;
        }
        else if (dieRoll == 2)
        {
            zombieText.text = "You've defeated the zombie, but got bitten in the process!";
            playerHealth.isPoisoned = true;
            enemyDied = true;

        }
        else if (dieRoll == 6)
        {
            //slipped past the zombie text
            zombieText.text = "You've snuck past the zombie";
            enemyDied = false;

            playerHealth.isPoisoned = true;
        }
        else
        {
            // text to say that zombie died
            zombieText.text = "You've defeated the zombie";
            enemyDied = true;

            playerHealth.isPoisoned = true;
        }
    }

    public void GiantSpiderRollDie()
    {
        if (isPlayer2)
        {
            giantSpiderRollDieButtonPlayer2.SetActive(false);
            giantSpiderContinueButtonPlayer2.SetActive(true);
        }
        else
        {
            giantSpiderRollDieButton.SetActive(false);
            giantSpiderContinueButton.SetActive(true);
        }

        dieRoll = Random.Range(1, 7);
        Debug.Log(dieRoll);


        if (dieRoll == 6)
        {
            giantSpiderText.text = "Spider Killed you!";
            playerHealth.gameOver = true;
        }
        else if (dieRoll == 5)
        {
            giantSpiderText.text = "The spider bit you. lose an token";
            playerHealth.isPoisoned = true; //placeholder
            //do playerInventory and make function to lose item

        }
        else
        {
            // text to say that zombie died
            giantSpiderText.text = "You've defeated the Spider";
            enemyDied = true;
        }
    }

    public void MinotaurRollDie()
    {
        Debug.Log("attacking minotaur");
        dieRoll = Random.Range(1, 7);

        minotaurText.text = "Minotaur lost " + dieRoll + " health!";
        minotaurScript.minotaurHp -= dieRoll;
        if(minotaurScript.minotaurHp <= 0)
        {
            //minotaur died
            minotaurScript.isMinotaurDead = true;
        }
        if (isPlayer2)
        {
            minotaurContinueButtonPlayer2.SetActive(true);
            minotaurRollDieButtonPlayer2.SetActive(false);
            minotaurContinueButton.SetActive(false);
            minotaurRollDieButton.SetActive(false);
        }
        else
        {
            minotaurContinueButtonPlayer2.SetActive(false);
            minotaurRollDieButtonPlayer2.SetActive(false);
            minotaurContinueButton.SetActive(true);
            minotaurRollDieButton.SetActive(false);
        }
        
    }

    public void MinotaurResumeGame()
    {
        Debug.Log("defends or dies");
        if (!minotaurScript.isMinotaurDead) // minotaur attacks
        {
            dieRoll = Random.Range(1, 7);
            minotaurText.text = "The Minotaur attacked you for " + dieRoll + " damage!";
            playerHealth.health -= dieRoll;
            if(playerHealth.health <= 0)
            {
                playerHealth.gameOver = true;
            }
            if (isPlayer2)
            {
                minotaurRollDieButton.SetActive(false);
                minotaurContinueButton.SetActive(false);
                minotaurRollDieButtonPlayer2.SetActive(true);
                minotaurContinueButtonPlayer2.SetActive(false);
            }
            else
            {
                minotaurRollDieButton.SetActive(true);
                minotaurContinueButton.SetActive(false);
                minotaurRollDieButtonPlayer2.SetActive(false);
                minotaurContinueButtonPlayer2.SetActive(false);
            }
        }
        else // get horns and delete minotaur
        {
            EncounterBackground.SetActive(false);
            MinotaurSprite.SetActive(false);
            minotaurRollDieButton.SetActive(false);
            minotaurContinueButton.SetActive(false);
            minotaurRollDieButtonPlayer2.SetActive(false);
            minotaurContinueButtonPlayer2.SetActive(false);


            //player inventory + horns
            Destroy(CurrentMonsterEvent);
            CurrentMonsterEvent = null;
        }
    }
    public void ZombieResumeGame()
    {        
        ZombieSprite.SetActive(false);
        EncounterBackground.SetActive(false);
        zombieRollDieButton.SetActive(false);
        zombieContinueButton.SetActive(false);
        zombieContinueButtonPlayer2.SetActive(false);
        zombieRollDieButtonPlayer2.SetActive(false);


        zombieText.text = "A Zombie Attacks!";


        if(enemyDied)
        {        
            Debug.Log("Enemy has died. Destroying CurrentMonsterEvent.");
            Destroy(CurrentMonsterEvent);
            CurrentMonsterEvent = null;
            enemyDied = false;
        }        


    }

    public void GiantSpiderResumeGame()
    {


        EncounterBackground.SetActive(false);
        ZombieSprite.SetActive(false);
        zombieRollDieButton.SetActive(false);
        zombieContinueButton.SetActive(false);
        zombieRollDieButtonPlayer2.SetActive(false);
        zombieContinueButtonPlayer2.SetActive(false);

        giantSpiderText.text = "A Giant Enemy Spider!";

        if (enemyDied)
        {
            Debug.Log("Enemy has died. Destroying CurrentMonsterEvent.");
            Destroy(CurrentMonsterEvent);
            CurrentMonsterEvent = null;
            enemyDied = false;
        }
    }
}
