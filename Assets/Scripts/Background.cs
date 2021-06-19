using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background : MonoBehaviour
{
    public float backgroundSpeed;

    void Update()
    {
        if (GameObject.FindGameObjectWithTag("Player") != null)
        {
            transform.position += new Vector3(0, backgroundSpeed * Time.deltaTime, 0);
        }
    }
}
