using System;
using TMPro;
using UnityEngine;

public class Timer : MonoBehaviour
{
    public Action GameOver;
    
    public TextMeshProUGUI TimeText;

    private float totalSeconds = 30 * 60;

    private float currentTime;

    public bool Running = true;

    private void Start()
    {
        currentTime = totalSeconds;
    }

    private void Update()
    {
        if (Running)
        {
            currentTime -= Time.deltaTime;

            int milis = (int)(currentTime * 1000) % 1000;
            int secs = (int)currentTime;
            int mins = secs / 60;

            int remainingSecs = secs - mins * 60;

            TimeText.text = $"{mins.ToString("00")}:{remainingSecs.ToString("00")}:{milis.ToString("000")}";

            if (currentTime < 0)
            {
                GameOver?.Invoke();
            }
        }
    }
}
