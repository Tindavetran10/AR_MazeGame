using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCoin : MonoBehaviour
{
    public GameObject theCoin;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.Rotate(0f,1f,0f,Space.Self);    
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player" )
        {
            Debug.Log("Triggered with: " + other.gameObject.tag);
            Destroy(gameObject);
            Vector3 randomPosition = new Vector3(Random.Range(-5, 5),1, Random.Range(-5, 5));
            Debug.Log("Spawning coin at position: " + randomPosition);
            Instantiate(theCoin, randomPosition, Quaternion.identity);
        }
    }
}
