using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerInventory : MonoBehaviour
{
    public bool isPlayer2;

    public PlayerScript playerScript;
    public EncounterEvent encounterEvent;


    public bool hasNecklease;
    public bool hasMagicAxe;
    public bool hasBracelet;
    public bool hasBrush;
    public bool hasDiary;
    public bool hasMirror;
    public bool hasPouch;
    public bool hasHorns;
    public bool hasRing;

    private void Start()
    {
        playerScript = GetComponent<PlayerScript>();
        encounterEvent = GetComponent<EncounterEvent>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(""))
        {

        }
    }
}
