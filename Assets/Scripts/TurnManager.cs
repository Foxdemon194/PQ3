using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TurnManager : MonoBehaviour
{
    public bool playerOneTurn;
    public bool turnOrderDecided;
    public bool firstTurn;

    public GameObject moveRoll1;
    public GameObject upArrow1;
    public GameObject rightArrow1;
    public GameObject downArrow1;
    public GameObject leftArrow1;

    public GameObject moveRoll2;
    public GameObject upArrow2;
    public GameObject rightArrow2;
    public GameObject downArrow2;
    public GameObject leftArrow2;

    public GameObject initialRoll1;
    public GameObject initialRoll2;
    public int pOR;
    public int pTR;

    public Text player1Result;
    public Text player2Result;

    public GameObject turnDecidePanel;
    public GameObject closeButton;


    private void Start()
    {
        turnOrderDecided = false;
        firstTurn = true;
    }

    private void Update()
    {
        if (!turnOrderDecided)
        {
            // if the value of pOR is 0, the roll button is enabled
            if (pOR == 0)
            {
                initialRoll1.SetActive(true);
            }
            if (pTR == 0)
            {
                initialRoll2.SetActive(true);
            }
            // if the value of pOR is greater than 0, the roll button is dissabled
            if (pOR > 0)
            {
                initialRoll1.SetActive(false);

            }
            if (pTR > 0)
            {
                initialRoll2.SetActive(false);

            }

            // if pOR isn't equal to zero and pTR isn't equal to zero
            if (pOR != 0 && pTR != 0)
            {
                if (pOR > pTR)
                {
                    playerOneTurn = true; 
                    turnOrderDecided = true;
                    closeButton.SetActive(true);

                    upArrow1.SetActive(false);
                    rightArrow1.SetActive(false);
                    downArrow1.SetActive(false);
                    leftArrow1.SetActive(false);

                    upArrow2.SetActive(false);
                    rightArrow2.SetActive(false);
                    downArrow2.SetActive(false);
                    leftArrow2.SetActive(false);
                }
                else if (pOR < pTR)
                {
                    playerOneTurn = false;
                    turnOrderDecided = true;
                    closeButton.SetActive(true);


                        moveRoll1.SetActive(false);
                        moveRoll2.SetActive(true);

                        upArrow1.SetActive(false);
                        rightArrow1.SetActive(false);
                        downArrow1.SetActive(false);
                        leftArrow1.SetActive(false);

                        upArrow2.SetActive(false);
                        rightArrow2.SetActive(false);
                        downArrow2.SetActive(false);
                        leftArrow2.SetActive(false);
}
                else
                {
                    pOR = 0;
                    pTR = 0;
                }
            }

        }

        if (!turnOrderDecided)
        {
            return;
        }
        else if(firstTurn)
        {
            if (playerOneTurn)
            {
                moveRoll1.SetActive(true);
                moveRoll2.SetActive(false);
                firstTurn = false;

            }
            else
            {
                moveRoll1.SetActive(false);
                moveRoll2.SetActive(true);
                firstTurn = false;

            }
        }


    }

    public void ChangePlayerTurn()
    {
        if(playerOneTurn)
        {
            playerOneTurn = false;
            moveRoll1.SetActive(true);
            moveRoll2.SetActive(false);
        }
        else
        {
            playerOneTurn = true;
            moveRoll1.SetActive(false);
            moveRoll2.SetActive(true);
        }
    }

    public void RollForOne()
    {
        pOR = Random.Range(1, 7);
        player1Result.text = pOR.ToString();
    }

    public void RollForTwo()
    {
        pTR = Random.Range(1, 7);
        player2Result.text = pTR.ToString();
    }

    public void ClosePanel()
    {
        turnDecidePanel.SetActive(false);
    }
}
