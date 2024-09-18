using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class MineExplode : MonoBehaviour
{
    public GameObject gameOverPanel;
    public ParticleSystem explosionEffect;
    private GameObject mine;
    private bool gamePaused = false; 

    // Start is called before the first frame update
    void Start()
    {
        mine = gameObject;
        explosionEffect.Stop();
        gameOverPanel.SetActive(false); 
    }

    // Update is called once per frame
    void Update()
    {
        
        if (gamePaused && Input.GetMouseButtonDown(0)) 
        {
            RestartGame();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            explosionEffect.Play();
            Destroy(other.gameObject); 
            Destroy(mine, explosionEffect.main.duration); 

            DeadPanel();
        }
    }

    private void DeadPanel()
    {
        gameOverPanel.SetActive(true);  
        Time.timeScale = 0f;            
        gamePaused = true;              
    }

    private void RestartGame()
    {
        gameOverPanel.SetActive(false);  
        Time.timeScale = 1f;             
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex); 
    }
}
