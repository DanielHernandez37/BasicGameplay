using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
     public GameObject[] animalPrefabs;
    private float spwanRangeX = 20;
    private float spwanRangeZ = 20;
    private float rightSpawnX = 25;
    private float rightSpawnZS = 15.0f;
    private float rightSpawnZE = 2.0f;


    void Start()
    {
        InvokeRepeating("SpanRandomAnimal", 2 , 2f);
    }

    // Update is called once per frame
    void Update()
    {



    }
    private void SpanRandomAnimal()
    {
        
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        Vector3 spawnPos = new Vector3(Random.Range(-spwanRangeX, spwanRangeX), 0, spwanRangeZ);
        Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation);
        
        Vector3 spawnPosRight = new Vector3(-rightSpawnX, 0, Random.Range(rightSpawnZS, rightSpawnZE));
        Instantiate(animalPrefabs[animalIndex], spawnPosRight, animalPrefabs[animalIndex].transform.rotation = Quaternion.Euler(0,90,0));
        
        animalPrefabs[animalIndex].transform.rotation = Quaternion.Euler(0, 270, 0);

        Vector3 spawnPosleft = new Vector3(rightSpawnX, 0, Random.Range(rightSpawnZS, rightSpawnZE));
        Instantiate(animalPrefabs[animalIndex], spawnPosleft, animalPrefabs[animalIndex].transform.rotation);
       
        animalPrefabs[animalIndex].transform.rotation = Quaternion.Euler(0, 180, 0);
    }
} 