/*
Piper Abbott-Phillips
DestroyImageOnButtonPress.cs
Project 2
Code allows for text and image elements to be assigned and both enabled/destroyed on button press. 
*/
using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

public class DestroyImageOnButtonPress : MonoBehaviour
{
    public List<Image> imagesToDestroy = new List<Image>();
    public Text tutorialText2;
    public List<Image> imagesToEnable = new List<Image>();

  
    public void ModifyUIElements()
    {
        foreach (Image image in imagesToDestroy)
        {
            if (image != null)
            {
                Destroy(image.gameObject);
            }
        }

       
        imagesToDestroy.Clear();

     
        if (tutorialText2 != null)
        {
            tutorialText2.gameObject.SetActive(true);
        }

     
        foreach (Image image in imagesToEnable)
        {
            if (image != null)
            {
                image.gameObject.SetActive(true);
            }
        }
    }
}
