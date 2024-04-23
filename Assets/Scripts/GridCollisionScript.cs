using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridCollisionScript : MonoBehaviour
{
    public Material baseMaterial = null;
    public Material walkableMaterial = null;
    public Renderer rend = null;
    public Renderer rend2 = null;
    public GridManagerScript gridManagerScript; //needs to be assigned a new one for player 2

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Floor"))
        {
            if (rend != null)
            {
                rend2 = rend;
            }

            rend = other.GetComponent<Renderer>();
            if (rend2 != null)
            {
                rend2.material = baseMaterial;
            }
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if(other.CompareTag("Floor") && gridManagerScript.canMove)
        {
            rend.material = walkableMaterial;
        }
        else
        {
            rend.material = baseMaterial;
        }
    }
}
