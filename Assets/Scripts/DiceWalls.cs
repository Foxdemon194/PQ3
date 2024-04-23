using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiceWalls : MonoBehaviour
{

    public int myNumber;
    public DiceScript ds;
    public Rigidbody rb;
    //Transform parentTrans;
    Rigidbody parentRB;
    bool amTouching = false;

    private void Start()
    {
        parentRB = GetComponentInParent<Rigidbody>();
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("diceFloor"))
        {
            ds.NewRolledNumber(myNumber);
            //amTouching = true;
            //parentRB.isKinematic = true;
            //parentRB.useGravity = false;
            //parentRB.velocity = Vector3.zero;
            //parentRB.transform.localPosition = new Vector3(0f, 0f, 8.98f);
           // parentRB.transform.localRotation = Quaternion.identity;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if(amTouching)
        {
            //parentRB.isKinematic = false;
            //parentRB.useGravity = true;
            //amTouching = false;
        }
    }
}
