using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playerInventory : MonoBehaviour
{
    public bool isPlayer2;

    public PlayerScript playerScript;
    public EncounterEvent encounterEvent;
    public PlayerHealth playerHealth;



    public int totalItems;

    public bool hasLocket;
    public Image locketImage;
    public bool hasMagicAxe;
    public Image magicAxeImage;
    public bool hasBracelet;
    public Image braceletImage;
    public bool hasBrush;
    public Image brushImage;
    public bool hasDiary;
    public Image diaryImage;
    public bool hasMirror;
    public Image mirrorImage;
    public bool hasPouch;
    public Image pouchImage;
    public bool hasHorns;
    public Image hornsImage;
    public bool hasRing;
    public Image ringImage;

    private void Start()
    {
        playerScript = GetComponent<PlayerScript>();
        encounterEvent = GetComponent<EncounterEvent>();
        playerHealth = GetComponent<PlayerHealth>();
    }

    private void Update()
    {
        if (hasHorns)
        {
            hornsImage.color = isPlayer2 ? Color.blue : Color.red;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (!playerHealth.isPoisoned)
        {


            if (other.CompareTag("Locket") && playerScript.movementLeft == 0)
            {
                hasLocket = true;
                other.gameObject.SetActive(false);
                totalItems++;
                locketImage.color = encounterEvent.isPlayer2 ? Color.blue : Color.red;
            }
            if (other.CompareTag("Ring") && playerScript.movementLeft == 0)
            {
                hasRing = true;
                other.gameObject.SetActive(false);
                totalItems++;
                ringImage.color = encounterEvent.isPlayer2 ? Color.blue : Color.red;
            }
            if (other.CompareTag("Bracelet") && playerScript.movementLeft == 0)
            {
                hasBracelet = true;
                other.gameObject.SetActive(false);
                totalItems++;
                braceletImage.color = encounterEvent.isPlayer2 ? Color.blue : Color.red;
            }
            if (other.CompareTag("Diary") && playerScript.movementLeft == 0)
            {
                hasDiary = true;
                other.gameObject.SetActive(false);
                totalItems++;
                diaryImage.color = encounterEvent.isPlayer2 ? Color.blue : Color.red;
            }
            if (other.CompareTag("MoneyPouch") && playerScript.movementLeft == 0)
            {
                hasPouch = true;
                other.gameObject.SetActive(false);
                totalItems++;
                pouchImage.color = encounterEvent.isPlayer2 ? Color.blue : Color.red;
            }
            if (other.CompareTag("Mirror") && playerScript.movementLeft == 0)
            {
                hasMirror = true;
                other.gameObject.SetActive(false);
                totalItems++;
                mirrorImage.color = encounterEvent.isPlayer2 ? Color.blue : Color.red;
            }
            if (other.CompareTag("HairBrush") && playerScript.movementLeft == 0)
            {
                hasBrush = true;
                other.gameObject.SetActive(false);
                totalItems++;
                brushImage.color = encounterEvent.isPlayer2 ? Color.blue : Color.red;
            }
            if (other.CompareTag("MagicAxe") && playerScript.movementLeft == 0)
            {
                other.gameObject.SetActive(false);
                collectedMagicAxe();
            }
        }

    }

    public void collectedMagicAxe()
    {
        hasMagicAxe = true;
        //totalItems++;

        if (encounterEvent.isPlayer2)
        {
            magicAxeImage.color = Color.blue;
        }
        else
        {
            magicAxeImage.color = Color.red;
        }
    }

}
