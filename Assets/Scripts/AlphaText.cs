using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine.UI;

public class AlphaText : MonoBehaviour
{
    public float minTime = 0.8f;
    public float maxTime = 0.8f;

    private float timer;
    private Text textFlicker;

    private void Start()
    {
        textFlicker = GetComponent<Text>();
        timer = Random.Range(minTime, maxTime);
    }

    private void Update()
    {
        timer -= Time.deltaTime;
        if(timer <= 0 )
        {
            textFlicker.enabled = !textFlicker.enabled;
            timer = Random.Range(minTime, maxTime);
        }
    }
}
