using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerInventory : MonoBehaviour
{
    public bool isPlayer2;

    public PlayerScript playerScript;
    public EncounterEvent encounterEvent;

    public int totalItems;

    public bool hasLocket;
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
        if (other.CompareTag("Locket") && playerScript.movementLeft == 0)
        {
            hasLocket = true;
            other.gameObject.SetActive(false);
            totalItems++;
        }
        if (other.CompareTag("Ring") && playerScript.movementLeft == 0)
        {
            hasRing = true;
            other.gameObject.SetActive(false);
            totalItems++;

        }
        if (other.CompareTag("Bracelet") && playerScript.movementLeft == 0)
        {
            hasBracelet = true;
            other.gameObject.SetActive(false);
            totalItems++;

        }
        if (other.CompareTag("Diary") && playerScript.movementLeft == 0)
        {
            hasDiary = true;
            other.gameObject.SetActive(false);
            totalItems++;

        }
        if (other.CompareTag("MoneyPouch") && playerScript.movementLeft == 0)
        {
            hasPouch = true;
            other.gameObject.SetActive(false);
            totalItems++;

        }
        if (other.CompareTag("Mirror") && playerScript.movementLeft == 0)
        {
            hasMirror = true;
            other.gameObject.SetActive(false);
            totalItems++;

        }
        if (other.CompareTag("HairBrush") && playerScript.movementLeft == 0)
        {
            hasBrush = true;
            other.gameObject.SetActive(false);
            totalItems++;

        }
        if (other.CompareTag("MagicAxe") && playerScript.movementLeft == 0)
        {
            hasMagicAxe = true;
            other.gameObject.SetActive(false);
            totalItems++;

        }

    }
}
