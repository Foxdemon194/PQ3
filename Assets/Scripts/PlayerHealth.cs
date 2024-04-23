using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    public float health = 20f;
    public bool isPoisoned;
    public bool gameOver;
    public Slider healthSlider;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        healthSlider.value = health;

        if (health <= 0)
        {
            health = 0;
            gameOver = true;
        }
    }
}
