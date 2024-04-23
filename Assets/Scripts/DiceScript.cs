using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiceScript : MonoBehaviour
{
    public int currentNumber;

    public PlayerScript ps;

    public void NewRolledNumber(int newNumber)
    {
        currentNumber = newNumber;
        ps.movementLeft = currentNumber;
    }


}
