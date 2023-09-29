﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewDragAndDrop : MonoBehaviour
{
    Vector3 MousePositionOffset;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private Vector3 GetMouseWorldPosition()
    {
        return Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }

    private void OnMouseDown()
    {
        Debug.Log("OnMouseDown");
        MousePositionOffset = gameObject.transform.position - GetMouseWorldPosition();
    }

    private void OnMouseDrag()
    {
        Debug.Log("OnMouseDrag");

        transform.position = GetMouseWorldPosition() + MousePositionOffset;
    }
}