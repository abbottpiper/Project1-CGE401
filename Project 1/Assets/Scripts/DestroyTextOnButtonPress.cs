/*
Piper Abbott-Phillips
DestroyTextOnButtonPress.cs
Project 2
Code destroys assigned text on button press
*/
using UnityEngine;
using UnityEngine.UI;

public class DestroyTextOnButtonPress : MonoBehaviour
{
    public Text textToDestroy;

    
    public void DestroyTextObject()
    {
        if (textToDestroy != null)
        {
            Destroy(textToDestroy.gameObject);
        }
    }
}
