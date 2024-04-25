using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class disableaudio : MonoBehaviour
{
    public GameObject winScreen;
    public GameObject loseScreen;

    private AudioSource audioSource;

    // Update is called once per frame
    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }
    void Update()
    {
        if(winScreen.activeInHierarchy || loseScreen.activeInHierarchy)
        {
            audioSource.enabled = false;
        }
    }
}
