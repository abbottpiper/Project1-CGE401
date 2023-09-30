using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CounterOrange : MonoBehaviour
{
    public int totalCount;

    public int totalFood;

    public int orangeCount = 2;

    private void Start()
    {
        totalCount = 0;
        totalFood = 0;
    }

    public void AddToScore()
    {
        totalCount += 1;
        totalFood += orangeCount;
    }
}
