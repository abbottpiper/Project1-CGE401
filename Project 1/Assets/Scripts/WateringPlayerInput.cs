/*
Piper Abbott-Phillips
WateringPlayerInput.cs
Project 2
Code allows player to apply upwards force to a game object in order to balance it in a specificed area
*/
using UnityEngine;

public class WateringPlayerInput : MonoBehaviour
{
    public FallingBar fallingBar; 
    public float clickForce = 5.0f; 
    public float clickDuration = 0.1f; 

    private float clickTimer = 0f;
    private bool isClicking = false;

    private void Update()
    {
      
        if (Input.GetMouseButtonDown(0))
        {
           
            clickTimer = 0f;
            isClicking = true;
        }

        if (isClicking)
        {
          
            fallingBar.GetComponent<Rigidbody2D>().velocity = Vector2.up * clickForce;

            
            clickTimer += Time.deltaTime;

            
            if (clickTimer >= clickDuration)
            {
                isClicking = false;
            }
        }
    }
}
