using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MinotaurEncounter : MonoBehaviour
{
    public Slider MinotaurHPSlider;
    public int minotaurHp;
    public bool isMinotaurDead;
    public GameObject[] minotaurEventsSpots;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MinotaurHPSlider.value = minotaurHp;

        if (isMinotaurDead)
        {
            for (int i = 0; i < minotaurEventsSpots.Length; i++)
            {
                Destroy(minotaurEventsSpots[i]);
            }
        }
    }
}
