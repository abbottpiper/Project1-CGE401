/*
Denver Heneghan
CountOrders.cs
Project 2
This script keeps track of the values assigned to each fruit and vegetable object. Each object is assigned a number 1 through 10. It also
initializes totalCount and totalFood. Both of them are set to 0 in Start. There are ten different voids, one for each fruit. Each void adds
one to the totalCount and it adds the value assigned to the object to totalFood. These voids are then called by objects in the Unity scene,
or in other scripts. Each fruit and vegetable has four images that can be set to visible. Which image is shown depends on what number totalCount 
is. When the void is called, the script checks totalCount, then makes the correct image visible. 
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

    public GameObject Banana1;
    public GameObject Banana2;
    public GameObject Banana3;
    public GameObject Banana4;

    public GameObject Watermelon1;
    public GameObject Watermelon2;
    public GameObject Watermelon3;
    public GameObject Watermelon4;

    public GameObject Berry1;
    public GameObject Berry2;
    public GameObject Berry3;
    public GameObject Berry4;

    public GameObject Tomato1;
    public GameObject Tomato2;
    public GameObject Tomato3;
    public GameObject Tomato4;

    public GameObject Corn1;
    public GameObject Corn2;
    public GameObject Corn3;
    public GameObject Corn4;

    public GameObject Potato1;
    public GameObject Potato2;
    public GameObject Potato3;
    public GameObject Potato4;

    public GameObject Turnip1;
    public GameObject Turnip2;
    public GameObject Turnip3;
    public GameObject Turnip4;

    public GameObject Carrot1;
    public GameObject Carrot2;
    public GameObject Carrot3;
    public GameObject Carrot4;

    private void Start()
    {
        totalCount = 0;
        totalFood = 0;
    }

    public void Clear()
    {
        totalFood = 0;
        totalCount = 0;
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

        if (totalCount == 1)
        {
            Banana1.gameObject.SetActive(true);
        }
        else if (totalCount == 2)
        {
            Banana2.gameObject.SetActive(true);
        }
        else if (totalCount == 3)
        {
            Banana3.gameObject.SetActive(true);
        }
        else if (totalCount == 4)
        {
            Banana4.gameObject.SetActive(true);
        }
    }

    public void AddWatermelonToScore()
    {
        totalCount++;
        totalFood += watermelonCount;

        if (totalCount == 1)
        {
            Watermelon1.gameObject.SetActive(true);
        }
        else if (totalCount == 2)
        {
            Watermelon2.gameObject.SetActive(true);
        }
        else if (totalCount == 3)
        {
            Watermelon3.gameObject.SetActive(true);
        }
        else if (totalCount == 4)
        {
            Watermelon4.gameObject.SetActive(true);
        }
    }

    public void AddBerryToScore()
    {
        totalCount++;
        totalFood += berryCount;

        if (totalCount == 1)
        {
            Berry1.gameObject.SetActive(true);
        }
        else if (totalCount == 2)
        {
            Berry2.gameObject.SetActive(true);
        }
        else if (totalCount == 3)
        {
            Berry3.gameObject.SetActive(true);
        }
        else if (totalCount == 4)
        {
            Berry4.gameObject.SetActive(true);
        }
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

        if (totalCount == 1)
        {
            Potato1.gameObject.SetActive(true);
        }
        else if (totalCount == 2)
        {
            Potato2.gameObject.SetActive(true);
        }
        else if (totalCount == 3)
        {
            Potato3.gameObject.SetActive(true);
        }
        else if (totalCount == 4)
        {
            Potato4.gameObject.SetActive(true);
        }
    }

    public void AddTurnipToScore()
    {
        totalCount++;
        totalFood += turnipCount;


        if (totalCount == 1)
        {
            Turnip1.gameObject.SetActive(true);
        }
        else if (totalCount == 2)
        {
            Turnip2.gameObject.SetActive(true);
        }
        else if (totalCount == 3)
        {
            Turnip3.gameObject.SetActive(true);
        }
        else if (totalCount == 4)
        {
            Turnip4.gameObject.SetActive(true);
        }
    }

    public void AddCarrotToScore()
    {
        totalCount++;
        totalFood += carrotCount;

        if (totalCount == 1)
        {
            Carrot1.gameObject.SetActive(true);
        }
        else if (totalCount == 2)
        {
            Carrot2.gameObject.SetActive(true);
        }
        else if (totalCount == 3)
        {
            Carrot3.gameObject.SetActive(true);
        }
        else if (totalCount == 4)
        {
            Carrot4.gameObject.SetActive(true);
        }
    }
}
