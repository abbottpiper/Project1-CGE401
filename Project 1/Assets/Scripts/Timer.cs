using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public HealthSystem healthSystemScript;

    public float startTime = 15;

    public Text TimerText;

    public void Update()
    {
        startTime -= Time.deltaTime;
        TimerText.text = (startTime).ToString("0");

        if (startTime < 0)
        {
            startTime += 15;
            healthSystemScript.TakeDamage();
        }
    }

    public void Restart()
    {
        startTime = 15;
        TimerText.text = (startTime).ToString("startTime");
    }
}
