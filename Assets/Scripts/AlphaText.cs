using UnityEngine;
using TMPro; 

public class AlphaText : MonoBehaviour
{
    public float speedFade = 1f;
    private float count;
    public TextMeshProUGUI textMeshPro; 

    // Use this for initialization
    void Start()
    {
        if (textMeshPro == null)
        {
            Debug.LogError("TextMeshPro chưa được gán! Hãy gán nó trong Editor.");
        }
    }

    // Update is called once per frame
    void Update()
    {
        count += speedFade * Time.deltaTime;
        Color currentColor = textMeshPro.color;
        float alpha = Mathf.Sin(count) * 0.5f + 0.5f; 
        textMeshPro.color = new Color(currentColor.r, currentColor.g, currentColor.b, alpha);
    }
}
