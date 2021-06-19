using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public float cameraSpeed;

    void Update()
    {
        if (GameObject.FindGameObjectWithTag("Player") != null)
        {
            transform.position += new Vector3(0, cameraSpeed * Time.deltaTime, 0);
        }
    }
}