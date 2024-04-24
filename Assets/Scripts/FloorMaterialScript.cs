using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorMaterialScript : MonoBehaviour
{
    public Material greyMat;
    public Material whiteMat;

    public Renderer ren;

    public bool mayI = true;

    private void FixedUpdate()
    {
        ren.material = greyMat;
    }

    private void OnTriggerStay(Collider other)
    {
        if(other.CompareTag("FloorChecker") && mayI)
        {
            ren.material = whiteMat;
        }
    }
}
