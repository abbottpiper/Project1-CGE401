/*
Denver Heneghan
FlyController.cs
Project 2
This code was meant to spawn the fly object and check if that object is on screen. This code was not used in the final version of the game.
*/

using UnityEngine;

public class FlyController : MonoBehaviour
{
    private GameObject flyObject;

    void Start()
    {
       
        flyObject = GameObject.Find("Fly");

        
        if (flyObject != null)
        {
            flyObject.SetActive(false);
        }
        else
        {
            Debug.LogError("Fly object not found in the scene.");
        }

        
        InvokeRepeating("EnableFlyObject", 40f, 60f);
    }

    void EnableFlyObject()
    {
        if (flyObject != null)
        {
           
            flyObject.SetActive(true);
        }
    }
}
