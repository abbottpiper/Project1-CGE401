/*
Piper Abbott-Phillips
FallingBar
Project 2
Code pushes object down with gravity, holds it within the confines of the UI bar, and allows the player to apply upwards force with a mouseclick
*/
using UnityEngine;

public class FallingBar : MonoBehaviour
{
    public float fallSpeed = 2.0f; 
    public float maxYPosition = 4.0f; 
    public float minYPosition = -4.0f; 

    private void Update()
    {
       
        transform.Translate(Vector3.down * fallSpeed * Time.deltaTime);

        
        transform.position = new Vector3(transform.position.x, Mathf.Clamp(transform.position.y, minYPosition, maxYPosition), transform.position.z);
    }
}

public class PlayerController : MonoBehaviour
{
    public FallingBar fallingBar;
    public float clickForce = 1.0f; 

    private void Update()
    {
        
        if (Input.GetMouseButtonDown(0))
        {
            
            fallingBar.GetComponent<Rigidbody2D>().velocity = Vector2.up * clickForce;
        }
    }
}
