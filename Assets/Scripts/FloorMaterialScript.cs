using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorMaterialScript : MonoBehaviour
{
    public Material greyMat;
    public Material whiteMat;

    public Renderer ren;

    private void FixedUpdate()
    {
        ren.material = greyMat;
    }

    private void OnTriggerStay(Collider other)
    {
        if(other.CompareTag("FloorChecker"))
        {
            ren.material = whiteMat;
        }
    }
}
