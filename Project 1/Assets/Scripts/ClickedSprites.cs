using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickedSprites : MonoBehaviour
{
    public GameObject appleSeeds;

    private bool isClicked;
    bool isAppleSeeds = false;
    int appleSeedsNum = 1;

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        if (Input.GetMouseButtonDown(0))
        {
            isClicked = true;
        }
    }

    private void OnMouseUp()
    {
        isClicked = false;
    }

    private void OnMouseOver()
    {
        
    }
}
