using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ClickedSprites : MonoBehaviour
{
    public bool mouseClick;
    int totalCount = 0;
    int countApple = 1;
    int orderOneDone = 4;

    private void Update()
    {
        if (mouseClick == true)
        {
            totalCount += countApple;

            mouseClick = false;
        }
    }

    private void OnMouseDown()
    {
        mouseClick = true;
    }
}
