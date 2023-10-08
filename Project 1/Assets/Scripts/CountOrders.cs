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
    public int bananaCount = 10;
    public int watermelonCount = 8;
    public int berryCount = 9;
    public int cornCount = 3;
    public int tomatoCount = 4;
    public int potatoCount = 6;
    public int turnipCount = 7;
    public int carrotCount = 5;

    private void Start()
    {
        totalCount = 0;
        totalFood = 0;
    }

    public void AddAppleToScore()
    {
        totalCount++;
        totalFood += appleCount;
    }

    public void AddOrangeToScore()
    {
        totalCount++;
        totalFood += orangeCount;
    }

    public void AddBananaToScore()
    {
        totalCount++;
        totalFood += bananaCount;
    }

    public void AddWatermelonToScore()
    {
        totalCount++;
        totalFood += watermelonCount;
    }

    public void AddBerryToScore()
    {
        totalCount++;
        totalFood += berryCount;
    }

    public void AddCornToScore()
    {
        totalCount++;
        totalFood += cornCount;
    }

    public void AddTomatoToScore()
    {
        totalCount++;
        totalFood += tomatoCount;
    }

    public void AddPotatoToScore()
    {
        totalCount++;
        totalFood += potatoCount;
    }

    public void AddTurnipToScore()
    {
        totalCount++;
        totalFood += turnipCount;
    }

    public void AddCarrotToScore()
    {
        totalCount++;
        totalFood += carrotCount;
    }
}
