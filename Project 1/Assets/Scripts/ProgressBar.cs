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
