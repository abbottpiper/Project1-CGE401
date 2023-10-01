using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountOrders : MonoBehaviour
{
    public int totalCount;

    public int totalFood;

    public int appleCount = 1;
    public int orangeCount = 2;
    public int cornCount = 3;
    public int tomatoCount = 4;

    private void Start()
    {
        totalCount = 0;
        totalFood = 0;
    }

    public void AddAppleToScore()
    {
        totalCount += 1;
        totalFood += appleCount;
    }

    public void AddOrangeToScore()
    {
        totalCount += 1;
        totalFood += orangeCount;
    }

    public void AddCornToScore()
    {
        totalCount += 1;
        totalFood += cornCount;
    }

    public void AddTomatoToScore()
    {
        totalCount += 1;
        totalFood += tomatoCount;
    }
}
