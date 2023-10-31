/*
Denver Heneghan
Timer.cs
Project 2
This code sets a timer at 20 seconds. It also displayed that time on screen in a text box. While the time was greater than 0, the timer would
count down once every frame. It would then change the text on screen to match the countdown so the player could see the countdown. If the 
timer reached 0, the script would call the takeDamage void from the HealthSystem script, and the player would lose a heart. Then the timer
would add another 20 seconds to it, and because it would again be above zero, the process would repeat. This means the timer will restart
automatically once it hits zero. There is also the restart void which sets the timer and the text on screen back to the number 
20 when it is called. It can be called when the ticket objects in unity are clicked. The timer only starts once the player hits space. The script
also sets Time.timeScale to 1 when space is pressed to make sure the timer begins to count down when space is pressed.
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public HealthSystem healthSystemScript;

    public float startTime = 20;

    public bool beginTimer = false;

    public Text TimerText;

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            beginTimer = true;
            Time.timeScale = 1;
        }

        if (beginTimer == true)
        {
            startTime -= Time.deltaTime;
            TimerText.text = (startTime).ToString("0");

            if (startTime < 0)
            {
                startTime += 20;
                healthSystemScript.TakeDamage();
            }
        }
    }

    public void Restart()
    {
        startTime = 20;
        TimerText.text = (startTime).ToString("startTime");
    }
}
