using System.Collections;
using TMPro;
using UnityEngine;

public class BlinkText : MonoBehaviour
{
    public TextMeshProUGUI pressAnyButtonText;
    public float blinkInterval = 0.5f; 
    private void Start()
    {
        if (pressAnyButtonText == null)
        {
            
            return;
        }

        
        StartCoroutine(Blink());
    }

    IEnumerator Blink()
    {
        while (true)
        {
           
            pressAnyButtonText.enabled = !pressAnyButtonText.enabled;
            yield return new WaitForSecondsRealtime(blinkInterval);
        }
    }
}
