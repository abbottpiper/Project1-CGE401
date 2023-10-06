/*
Piper Abbott-Phillips
SpaceToDestroyText.cs
Project 2
Code destroys last tutorial image object when the player presses the spacebar
*/
using UnityEngine;
using UnityEngine.UI;

public class SpaceToDestroyImage : MonoBehaviour
{
    public Image imageToDestroy;

   
    void Update()
    {
       
        if (Input.GetKeyDown(KeyCode.Space))
        {
            
            if (imageToDestroy != null)
            {
                
                Destroy(imageToDestroy.gameObject);
            }
        }
    }
}
