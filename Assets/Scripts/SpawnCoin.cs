using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCoin : MonoBehaviour
{
    public GameObject coinPrefab;
    public Transform spawnArea;
    public List<GameObject> walls;

    public static SpawnCoin instance; // Singleton để dễ dàng gọi từ script khác

    void Awake()
    {
        instance = this; // Gán đối tượng hiện tại cho instance
    }

    void Start()
    {
        SpawnNewCoin(); // Spawn đồng xu đầu tiên
    }

    public void SpawnNewCoin()
    {
        Vector3 spawnPosition;
        bool validPosition = false;

        // Tạo vị trí spawn hợp lệ trên các đối tượng có tag là "Plane" và tránh các đối tượng có tag là "Wall"
        while (!validPosition)
        {
            spawnPosition = new Vector3(
                Random.Range(spawnArea.position.x - spawnArea.localScale.x / 2, spawnArea.position.x + spawnArea.localScale.x / 2),
                spawnArea.position.y,
                Random.Range(spawnArea.position.z - spawnArea.localScale.z / 2, spawnArea.position.z + spawnArea.localScale.z / 2)
            );

            Collider[] hits = Physics.OverlapSphere(spawnPosition, 0.5f);
            bool isOnPlane = false;
            bool collidesWithWall = false;

            foreach (Collider hit in hits)
            {
                if (hit.CompareTag("Plane"))
                {
                    isOnPlane = true; // Vị trí hợp lệ nếu trên mặt phẳng "Plane"
                }

                if (hit.CompareTag("Wall"))
                {
                    collidesWithWall = true; // Vị trí không hợp lệ nếu chạm "Wall"
                    break;
                }
            }

            if (isOnPlane && !collidesWithWall)
            {
                validPosition = true;

                // Tạo đồng xu tại vị trí hợp lệ
                Instantiate(coinPrefab, spawnPosition, Quaternion.identity);
            }
        }
    }
}
