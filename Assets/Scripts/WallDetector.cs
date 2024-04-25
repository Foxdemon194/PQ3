using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallDetector : MonoBehaviour
{
    public GameObject floorTrigger;
    public int directionNum;
    public GameObject arrow;
    public PlayerScript playerScript;

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Wall"))
        {
            // Disable the corresponding arrow based on the directionNum
            switch (directionNum)
            {
                case 1: // Up
                    playerScript.upTrue = false;
                    break;
                case 2: // Right
                    playerScript.rightTrue = false;
                    break;
                case 3: // Down
                    playerScript.downTrue = false;
                    break;
                case 4: // Left
                    playerScript.leftTrue = false;
                    break;
                default:
                    break;
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Wall"))
        {
            playerScript.upTrue = true;
            playerScript.rightTrue = true;
            playerScript.downTrue = true;
            playerScript.leftTrue = true;
        }
    }
}
