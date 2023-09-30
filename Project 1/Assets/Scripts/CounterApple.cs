using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CounterApple : MonoBehaviour
{
    public int totalCount;

    public int totalFood;

    public int appleCount = 1;

    private void Start()
    {
        totalCount = 0;
        totalFood = 0;
    }

    public void AddToScore()
    {
        totalCount += 1;
        totalFood += appleCount;
    }
}
