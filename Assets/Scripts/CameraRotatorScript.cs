using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRotatorScript : MonoBehaviour
{
    public float speed = 1f;
    void Update()
    {
        transform.Rotate(0, speed * Time.deltaTime, 0);
    }
}
