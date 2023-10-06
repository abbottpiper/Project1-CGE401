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
