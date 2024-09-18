using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCoin : MonoBehaviour
{
    public GameObject coinPrefab;
    public Transform[] spawnPoints; // Mảng các điểm spawn
    public static SpawnCoin instance;

    private int lastSpawnIndex = -1; // Biến lưu lại vị trí spawn trước đó để tránh trùng lặp

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
        int randomIndex = GetRandomSpawnIndex(); // Chọn điểm spawn ngẫu nhiên từ mảng

        // Lấy vị trí của điểm spawn ngẫu nhiên
        Vector3 spawnPosition = spawnPoints[randomIndex].position;

        // Spawn đồng xu tại vị trí đã chọn
        Instantiate(coinPrefab, spawnPosition, Quaternion.identity);
    }

    // Hàm chọn chỉ số spawn point ngẫu nhiên, tránh trùng với lần trước
    private int GetRandomSpawnIndex()
    {
        int randomIndex;
        do
        {
            randomIndex = Random.Range(0, spawnPoints.Length);
        } while (randomIndex == lastSpawnIndex); // Đảm bảo không trùng với lần spawn trước

        lastSpawnIndex = randomIndex;
        return randomIndex;
    }
}
