using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ClickedSprites : MonoBehaviour
{
    public bool mouseClick;

    private void Update()
    {

    }

    private void OnMouseDown()
    {
        mouseClick = true;
    }

    private void OnMouseUp()
    {
        mouseClick = false;
    }
}
