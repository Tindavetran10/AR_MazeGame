using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Coins : MonoBehaviour
{
    private int Coin = 0;
    public TextMeshProUGUI coinText;
    private void OnTriggerEnter(Collider other)
    {
        // Kiểm tra xem đối tượng chạm vào là "Player" (bóng) hay không
        if (other.CompareTag("Player"))
        {
            Coin++;  
            coinText.text = "Point: " + Coin.ToString();
            SpawnCoin.instance.SpawnNewCoin();
            Destroy(gameObject);
        }
    }
}
