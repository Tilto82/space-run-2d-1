using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBackground : MonoBehaviour
{
    public GameObject planet;

    public float maxX;
    public float minX;

    public float timeBetweenSpawn;
    private float spawnTime;


    void Update()
    {
        if (Time.time > spawnTime)
        {
            if (GameObject.FindGameObjectWithTag("Player") != null)
            {
                Spawn();
                spawnTime = Time.time + timeBetweenSpawn;
            }
        }
    }

    void Spawn()
    {
        float randomX = Random.Range(minX, maxX);

        Instantiate(planet, transform.position + new Vector3(randomX, 0), transform.rotation);
    }
}
