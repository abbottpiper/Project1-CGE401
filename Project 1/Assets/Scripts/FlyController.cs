using UnityEngine;

public class FlyController : MonoBehaviour
{
    private GameObject flyObject;

    void Start()
    {
        // Find the GameObject with the name "Fly" in the scene
        flyObject = GameObject.Find("Fly");

        // Ensure the fly object is initially disabled
        if (flyObject != null)
        {
            flyObject.SetActive(false);
        }
       

        // Invoke the EnableFlyObject method after 40 seconds and repeat every 60 seconds
        InvokeRepeating("EnableFlyObject", 40f, 60f);
    }

    void EnableFlyObject()
    {
        if (flyObject != null)
        {
            // Enable the fly object
            flyObject.SetActive(true);
        }
    }
}
