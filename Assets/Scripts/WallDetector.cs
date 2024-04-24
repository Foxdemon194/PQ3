using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallDetector : MonoBehaviour
{
    public GameObject floorTrigger;
    public int directionNum;

    private void OnTriggerStay(Collider other)
    {
        if(other.CompareTag("Wall"))
        {
            floorTrigger.tag = "Ghost";
            if (directionNum == 1) 
            {
                GetComponentInParent<PlayerScript>().upTrue = true;
            }
            if (directionNum == 2)
            {
                GetComponentInParent<PlayerScript>().rightTrue = true;
            }
            if (directionNum == 3)
            {
                GetComponentInParent<PlayerScript>().downTrue = true;
            }
            if (directionNum == 4)
            {
                GetComponentInParent<PlayerScript>().leftTrue = true;
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Wall"))
        {
            floorTrigger.tag = "FloorChecker";
            if (directionNum == 1)
            {
                GetComponentInParent<PlayerScript>().upTrue = false;
            }
            if (directionNum == 2)
            {
                GetComponentInParent<PlayerScript>().rightTrue = false;
            }
            if (directionNum == 3)
            {
                GetComponentInParent<PlayerScript>().downTrue = false;
            }
            if (directionNum == 4)
            {
                GetComponentInParent<PlayerScript>().leftTrue = false;
            }
        }
    }
}
