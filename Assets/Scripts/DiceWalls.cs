using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiceWalls : MonoBehaviour
{

    public int myNumber;
    public DiceScript ds;
    public Rigidbody rb;


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("diceFloor"))
        {
                ds.NewRolledNumber(myNumber);
        }        
    }    
}
