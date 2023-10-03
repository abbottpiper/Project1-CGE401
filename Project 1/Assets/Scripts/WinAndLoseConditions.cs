using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WinAndLoseConditions : MonoBehaviour
{
    public CountOrders countOrdersScript;
    public HealthSystem healthSystemScript;

    public Text Order;

    public float time = 15.0f;

    // Start is called before the first frame update
    void Start()
    {
        Order = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        if (time > 0)
        {
            time -= Time.deltaTime;
        }
        else
        {
            time = 15.0f;
            healthSystemScript.TakeDamage();
        }
    }

    public void OrderOne()
    {
        if (countOrdersScript.totalFood == 4)
        {
            //Order.text = "Correct! Great Job!";
            time = 15.0f;

            countOrdersScript.totalCount = 0;
            countOrdersScript.totalFood = 0;
        }
        else
        {
            healthSystemScript.TakeDamage();
            //Order.text = "Incorrect, try again.";

            countOrdersScript.totalCount = 0;
            countOrdersScript.totalFood = 0;
        }
    }

    public void OrderTwo()
    {
        if (countOrdersScript.totalFood == 10)
        {
            //Order.text = "Correct! Great Job!";
            time = 15.0f;

            countOrdersScript.totalCount = 0;
            countOrdersScript.totalFood = 0;
        }
        else
        {
            healthSystemScript.TakeDamage();
            //Order.text = "Incorrect, try again.";

            countOrdersScript.totalCount = 0;
            countOrdersScript.totalFood = 0;
        }
    }

    public void OrderThree()
    {
        if (countOrdersScript.totalFood == 9)
        {
            //Order.text = "Correct! Great Job!";
            time = 15.0f;

            countOrdersScript.totalCount = 0;
            countOrdersScript.totalFood = 0;
        }
        else
        {
            healthSystemScript.TakeDamage();
            //Order.text = "Incorrect, try again.";

            countOrdersScript.totalCount = 0;
            countOrdersScript.totalFood = 0;
        }
    }
}
