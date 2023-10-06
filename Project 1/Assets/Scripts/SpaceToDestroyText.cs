/*
Piper Abbott-Phillips
SpaceToDestroyText.cs
Project 2
Code destroys last tutorial text object when the player presses the spacebar
*/
using UnityEngine;
using UnityEngine.UI;

public class SpaceToDestroyText : MonoBehaviour
{
    public Text textToDestroy;

    
    void Update()
    {
       
        if (Input.GetKeyDown(KeyCode.Space))
        {
         
            if (textToDestroy != null)
            {
               
                Destroy(textToDestroy.gameObject);
            }
        }
    }
}
