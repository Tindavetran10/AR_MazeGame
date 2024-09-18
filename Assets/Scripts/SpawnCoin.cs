using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCoin : MonoBehaviour
{
    public GameObject coinPrefab;
    public Transform[] spawnPoints; 
    public static SpawnCoin instance;

    private int lastSpawnIndex = -1; 

    void Awake()
    {
        instance = this;
    }

    void Start()
    {
        SpawnNewCoin();
    }

    public void SpawnNewCoin()
    {
        int randomIndex = GetRandomSpawnIndex();

        Vector3 spawnPosition = spawnPoints[randomIndex].position;
        Instantiate(coinPrefab, spawnPosition, Quaternion.identity);
    }

    private int GetRandomSpawnIndex()
    {
        int randomIndex;
        do
        {
            randomIndex = Random.Range(0, spawnPoints.Length);
        } while (randomIndex == lastSpawnIndex); 

        lastSpawnIndex = randomIndex;
        return randomIndex;
    }
}
