using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagerScript : MonoBehaviour
{
    public GameObject prologue;
    public GameObject players;
    public GameObject help;


    public void PlayOnePlayer()
    {
        SceneManager.LoadScene("GameScene01");
    }

    public void LookingForTwoPlayers()
    {
        SceneManager.LoadScene("LFMScene");
    }
    public void PlayTwoPlayer()
    {
        SceneManager.LoadScene("GameScene02");
    }

    public void Reset()
    {
        
    }

    public void LoadMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void Prologue()
    {
        if (prologue == null)
        {
        Debug.Log("Prologue was null");
        return; 
        }
        prologue.SetActive(true);
    }
    public void PrologueBack()
    {
        if (prologue == null)
        {
            Debug.Log("Prologue was null");
            return;
        }
        prologue.SetActive(false);
    }

    public void Players()
    {
        if (players == null)
        {
            Debug.Log("Prologue was null");
            return;
        }
        players.SetActive(true);
    }
    public void PlayerBack()
    {
        if (players == null)
        {
            Debug.Log("Prologue was null");
            return;
        }
        players.SetActive(false);
    }

    public void Help()
    {
        if (help == null)
        {
            Debug.Log("Prologue was null");
            return;
        }
        help.SetActive(true);
    }
    public void HelpBack()
    {
        if (help == null)
        {
            Debug.Log("Prologue was null");
            return;
        }
        help.SetActive(false);
    }

    public void Quit()
    {
        Application.Quit();
    }
}
