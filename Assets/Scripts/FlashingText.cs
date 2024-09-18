using System.Collections;
using UnityEngine;
using TMPro; 

public class FlashingText : MonoBehaviour
{
    public TextMeshProUGUI pressAnyButtonText; 
    public float flashSpeed = 1f; 

    private bool isFlashing = true;

    void Start()
    {
        StartCoroutine(FlashText()); 
    }

    IEnumerator FlashText()
    {
        while (isFlashing)
        {
            
            for (float alpha = 0; alpha <= 1; alpha += Time.deltaTime * flashSpeed)
            {
                SetTextAlpha(alpha);
                yield return null;
            }

            for (float alpha = 1; alpha >= 0; alpha -= Time.deltaTime * flashSpeed)
            {
                SetTextAlpha(alpha);
                yield return null;
            }
        }
    }

    void SetTextAlpha(float alpha)
    {
        
        Color textColor = pressAnyButtonText.color;
        textColor.a = alpha;
        pressAnyButtonText.color = textColor;
    }
}
