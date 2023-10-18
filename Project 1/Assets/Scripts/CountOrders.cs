/*
Denver Heneghan
CountOrders.cs
Project 2
This script keeps track of the values assigned to each fruit and vegetable object. Each object is assigned a number 1 through 10. It also
initializes totalCount and totalFood. Both of them are set to 0 in Start. There are ten different voids, one for each fruit. Each void adds
one to the totalCount and it adds the value assigned to the object to totalFood. These voids are then called by objects in the Unity scene,
or in other scripts.
*/

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

    public GameObject Apple1;
    public GameObject Apple2;
    public GameObject Apple3;
    public GameObject Apple4;

    public GameObject Orange1;
    public GameObject Orange2;
    public GameObject Orange3;
    public GameObject Orange4;

    public GameObject Tomato1;
    public GameObject Tomato2;
    public GameObject Tomato3;
    public GameObject Tomato4;

    public GameObject Corn1;
    public GameObject Corn2;
    public GameObject Corn3;
    public GameObject Corn4;

    private void Start()
    {
        totalCount = 0;
        totalFood = 0;
    }

    public void Clear()
    {
        totalCount = 0;
        totalFood = 0;
    }

    public void AddAppleToScore()
    {
        totalCount++;
        totalFood += appleCount;

        if (totalCount == 1)
        {
            Apple1.gameObject.SetActive(true);
        }
        else if (totalCount == 2)
        {
            Apple2.gameObject.SetActive(true);
        }
        else if (totalCount == 3)
        {
            Apple3.gameObject.SetActive(true);
        }
        else if (totalCount == 4)
        {
            Apple4.gameObject.SetActive(true);
        }
    }

    public void AddOrangeToScore()
    {
        totalCount++;
        totalFood += orangeCount;

        if (totalCount == 1)
        {
            Orange1.gameObject.SetActive(true);
        }
        else if (totalCount == 2)
        {
            Orange2.gameObject.SetActive(true);
        }
        else if (totalCount == 3)
        {
            Orange3.gameObject.SetActive(true);
        }
        else if (totalCount == 4)
        {
            Orange4.gameObject.SetActive(true);
        }
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

        if (totalCount == 1)
        {
            Corn1.gameObject.SetActive(true);
        }
        else if (totalCount == 2)
        {
            Corn2.gameObject.SetActive(true);
        }
        else if (totalCount == 3)
        {
            Corn3.gameObject.SetActive(true);
        }
        else if (totalCount == 4)
        {
            Corn4.gameObject.SetActive(true);
        }
    }

    public void AddTomatoToScore()
    {
        totalCount++;
        totalFood += tomatoCount;

        if (totalCount == 1)
        {
            Tomato1.gameObject.SetActive(true);
        }
        else if (totalCount == 2)
        {
            Tomato2.gameObject.SetActive(true);
        }
        else if (totalCount == 3)
        {
            Tomato3.gameObject.SetActive(true);
        }
        else if (totalCount == 4)
        {
            Tomato4.gameObject.SetActive(true);
        }
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
