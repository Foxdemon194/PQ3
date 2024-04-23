using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ZombieEvent : MonoBehaviour
{
    //public PlayerHealth playerHealth;
    //public PlayerScript playerScript;
    //// Start is called before the first frame update

    //private int dieRoll;
    //public Text zombieText;
    //public GameObject continueButton;
    //public GameObject rollDieButton;
    //public GameObject ZombieEncounter;
    //public GameObject Background;

    //public bool enemyDied;    
    
    //private void OnTriggerEnter(Collider other)
    //{
    //    Debug.Log(name);
    //    if (other.CompareTag("Player"))
    //    {
    //        Debug.Log("player inside");
    //        playerScript = other.GetComponent<PlayerScript>();

    //        if (playerScript.movementLeft == 0)
    //        {
    //            playerHealth = other.GetComponent<PlayerHealth>();
    //            Debug.Log("got player Health");
    //        }
    //    }
    //}


    //public void RollDie()
    //{

    //    rollDieButton.SetActive(false);
    //    continueButton.SetActive(true);
    //    dieRoll = Random.Range(1, 7);

    //    Debug.Log(dieRoll);


    //    if (dieRoll == 1)
    //    {
    //        zombieText.text = "Zombie Killed you!";
    //        playerHealth.gameOver = true;
    //    }
    //    else if (dieRoll == 2)
    //    {
    //        zombieText.text = "You've defeated the zombie, but got bitten in the process!";
    //        playerHealth.isPoisoned = true;
    //        enemyDied = true;

    //    }
    //    else if (dieRoll == 6)
    //    {
    //        //slipped past the zombie text
    //        zombieText.text = "You've snuck past the zombie";
    //    }
    //    else
    //    {
    //        // text to say that zombie died
    //        zombieText.text = "You've defeated the zombie";
    //        enemyDied = true;
    //    }
    //}


    //public bool IsEnemyDead()
    //{
    //    return enemyDied;
    //}
}
