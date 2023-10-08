/*
Denver Heneghan
ProgressBar.cs
Project 2
This code was meant to control the progress bar in the watering minigame. If the mouse was in the right area, the progress would increase.
This script was unused in the final version of the game.
*/

using UnityEngine;
using UnityEngine.UI;

public class ProgressBar : MonoBehaviour
{
    public FallingBar fallingBar; 
    public Slider progressBar; 
    public float minYPosition = -7.0f; 
    public float maxYPosition = 7.0f; 
    public float incrementSpeed = 0.1f; 

    private void Update()
    {
        
        float yPosition = fallingBar.transform.position.y;
        if (yPosition >= minYPosition && yPosition <= maxYPosition)
        {
            
            progressBar.value += incrementSpeed * Time.deltaTime;

            
            progressBar.value = Mathf.Clamp01(progressBar.value);
        }
    }
}
