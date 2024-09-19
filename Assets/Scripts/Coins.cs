using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Coins : MonoBehaviour
{
    private static int Coin = 0; 
    public TextMeshProUGUI coinText;

    private void Update()
    {
        gameObject.transform.Rotate(0f, 1f, 0f, Space.Self);
    }

    private void OnTriggerEnter(Collider other)
    {
        // Kiểm tra xem đối tượng chạm vào là "Player" (bóng) hay không
        if (other.CompareTag("Player"))
        {
            Coin++;
            coinText.text = "Point: " + Coin.ToString();
            Destroy(gameObject);
        }
    }
}
