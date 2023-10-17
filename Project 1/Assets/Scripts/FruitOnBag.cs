using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitOnBag : MonoBehaviour
{
    CountOrders countingScript;

    public GameObject Apple1;
    public GameObject Apple2;
    public GameObject Apple3;
    public GameObject Apple4;

    public void SpawnApple()
    {
        if (countingScript.totalCount == 1)
        {
            Apple1.gameObject.SetActive(true);
        }
        else if (true)
        {
            Apple2.gameObject.SetActive(true);
        }
    }

    public void SpawnOrange()
    {

    }

    public void SpawnTomato()
    {

    }

    public void SpawnCorn()
    {

    }
}
