using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosionCollsion : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnParticleCollision(GameObject other)
    {
        if(other.CompareTag("Player"))
        {
            Debug.Log("Nỗ chết nhân vật");
            Destroy(other.gameObject);
        }
    }
}
