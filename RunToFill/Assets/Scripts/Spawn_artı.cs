using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn_artı : MonoBehaviour
{
    public GameObject artı;
    public float maxX;
    public float maxY;
    public float minX;
    public float minY;
    public float timeBetweenSpawn;
    private float spawnTime;

    public GameObject[] objects;
    GameObject obj;


    void Start()
    {
        
    }

    
    void Update()
    {
        if(Time.time > spawnTime)
        {
            Spawn();
            spawnTime = Time.time + timeBetweenSpawn; 
        }
    }

    void Spawn()
    {
        float randomX = Random.Range(minX , maxX);
        float randomY = Random.Range(minY , maxY);

        Vector2 pos = new Vector2(randomX , randomY);

        GameObject obj = objects [Random.Range (0, objects.Length)];

        Instantiate (obj, transform.position + new Vector3(randomX , randomY , 0) , transform.rotation);
    }
}
