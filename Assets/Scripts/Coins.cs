using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coins : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        // Kiểm tra xem đối tượng chạm vào là "Player" (bóng) hay không
        if (other.CompareTag("Player"))
        {
            // Gọi hàm spawn coin trong script SpawnCoin
            SpawnCoin.instance.SpawnNewCoin();

            // Hủy đối tượng coin sau khi chạm
            Destroy(gameObject);
        }
    }
}
