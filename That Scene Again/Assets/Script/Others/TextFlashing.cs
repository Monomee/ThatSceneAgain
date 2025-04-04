using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class TextFlashing : MonoBehaviour
{
    public Color color1;
    public Color color2;
    public TextMeshProUGUI flashingText;
    // Update is called once per frame
    void Start()
    {
        StartCoroutine(FlashingTextCoroutine());
    }
    IEnumerator FlashingTextCoroutine()
    {
        while (true)
        {
            flashingText.color = Color.Lerp(color1, color2, Mathf.PingPong(Time.time, 1));
            yield return null;
        }       
    }
}
