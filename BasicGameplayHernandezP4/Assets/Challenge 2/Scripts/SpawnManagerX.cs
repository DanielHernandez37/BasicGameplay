
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerX : MonoBehaviour
{
    
    public GameObject[] ballPrefabs;

    private float spawnLimitXLeft = -14;
    private float spawnLimitXRight = 7;
    private float spawnPosY = 30;

    private float startDelay = 1.0f;

    // Start is called before the first frame update
    void Start()
    {
      
        Invoke("SpawnRandomBall", startDelay);
    }

    // Update is called once per frame
    void Update()
    {

    }

   
    void SpawnRandomBall()
    {
      
        int ballIndex  = Random.Range(0, ballPrefabs.Length);
        Vector3 spawnPos = new Vector3(Random.Range(spawnLimitXLeft, spawnLimitXRight), spawnPosY, 0);

        Instantiate(ballPrefabs[ballIndex], spawnPos, ballPrefabs[ballIndex].transform.rotation);
        
        float minSpawnInterval = 3.0f;
        float maxSpawnInterval = 5.0f;
        float spawnInterval;

        spawnInterval = Random.Range(minSpawnInterval, maxSpawnInterval);
        Invoke("SpawnRandomBall", spawnInterval);
    }

}