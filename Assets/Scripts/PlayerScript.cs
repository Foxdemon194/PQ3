using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerScript : MonoBehaviour
{
    public float rollForce = 10f;
    public GameObject dice;
    public float torqueForce = 10;

    public int movementLeft = 5;
    public float movementSpeed = 10f;
    public bool moving = false;
    Vector3 targetPosition;

    public GameObject upArrow;
    public GameObject rightArrow;
    public GameObject downArrow;
    public GameObject leftArrow;
    public GameObject rollDiceButton;

    public bool upTrue =true;
    public bool leftTrue = true;
    public bool downTrue = true;
    public bool rightTrue = true;

    public GameObject pauseMenu;
    public bool gameIsPaused;
    public Text movementText;

    public TurnManager turnManager;

    public bool isSingleplayer = false;

    private void Start()
    {
        gameIsPaused = false;
        movementLeft = 0;
        targetPosition = transform.position;
    }

    public void Update()
    {
        if (moving)
        {
            transform.position = Vector3.MoveTowards(transform.position, targetPosition, movementSpeed * Time.deltaTime);
            if (Vector3.Distance(transform.position, targetPosition) < movementSpeed * Time.deltaTime)
            {
                transform.position = targetPosition;
                moving = false;
                if(movementLeft > 0)
                {
                    CheckIfMovable();
                }
            }
        }
        
        if (Input.GetKeyDown(KeyCode.Escape)) //playtest button
        {
            Pause();
        }
        
    }

    public void CheckIfMovable()
    {
        if(upTrue)
        upArrow.SetActive(true);
        if(rightTrue)
        rightArrow.SetActive(true);
        if(downTrue)
        downArrow.SetActive(true);
        if(leftTrue)
        leftArrow.SetActive(true);
    }

    public void PlayerMoveUp()
    {
        targetPosition = new Vector3 (transform.position.x-1, transform.position.y, transform.position.z);
        moving = true;
        movementLeft--;
        upArrow.SetActive(false);
        rightArrow.SetActive(false);
        downArrow.SetActive(false);
        leftArrow.SetActive(false);
        movementText.text = movementLeft.ToString();
        if(movementLeft <= 0)
        {
            turnManager.ChangePlayerTurn();
        }

    }
    public void PlayerMoveRight()
    {
        targetPosition = new Vector3(transform.position.x, transform.position.y+1, transform.position.z);
        moving = true;
        movementLeft--;
        upArrow.SetActive(false);
        rightArrow.SetActive(false);
        downArrow.SetActive(false);
        leftArrow.SetActive(false);
        movementText.text = movementLeft.ToString();
        if (movementLeft <= 0)
        {
            turnManager.ChangePlayerTurn();
        }
    }
    public void PlayerMoveDown()
    {
        targetPosition = new Vector3(transform.position.x + 1, transform.position.y, transform.position.z);
        moving = true;
        movementLeft--;
        upArrow.SetActive(false);
        rightArrow.SetActive(false);
        downArrow.SetActive(false);
        leftArrow.SetActive(false);
        movementText.text = movementLeft.ToString();
        if (movementLeft <= 0)
        {
            turnManager.ChangePlayerTurn();
        }
    }
    public void PlayerMoveLeft()
    {
        targetPosition = new Vector3(transform.position.x, transform.position.y-1, transform.position.z);
        moving = true;
        movementLeft--;
        upArrow.SetActive(false);
        rightArrow.SetActive(false);
        downArrow.SetActive(false);
        leftArrow.SetActive(false);
        movementText.text = movementLeft.ToString();
        if (movementLeft <= 0)
        {
            turnManager.ChangePlayerTurn();
        }
    }

    public void RollDice()
    {
        movementLeft = Random.Range(1, 7);
        movementText.text = movementLeft.ToString();

        CheckIfMovable();
        rollDiceButton.SetActive(false);

        /*
        Vector3 rollDirection = new Vector3(Random.Range(-rollForce, rollForce), Random.Range(-rollForce, rollForce), 3*Random.Range(-rollForce / 2, -rollForce));//Random.onUnitSphere;
        Rigidbody rb = dice.GetComponent<Rigidbody>();
        float torqueX = (Random.Range(0f, 1f) < 0.5f ? -1 : 1) * Random.Range(torqueForce/2, torqueForce);
        float torqueY = (Random.Range(0f, 1f) < 0.5f ? -1 : 1) * Random.Range(torqueForce/2, torqueForce);
        float torqueZ = (Random.Range(0f, 1f) < 0.5f ? -1 : 1) * Random.Range(torqueForce/2, torqueForce);

        rb.AddTorque(new Vector3(torqueX, torqueY, torqueZ), ForceMode.Impulse);
        dice.GetComponent<Rigidbody>().AddForce((rollDirection * rollForce), ForceMode.Impulse);
        rollDiceButton.SetActive(false);
        */
    }

    public void Restart()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void Pause()
    {
        if (!gameIsPaused)
        {
            Time.timeScale = 0;
            gameIsPaused = true;
            pauseMenu.SetActive(true);
        }
        else if (gameIsPaused)
        {
            Time.timeScale = 1;
            gameIsPaused = false;
            pauseMenu.SetActive(false);
        }
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
