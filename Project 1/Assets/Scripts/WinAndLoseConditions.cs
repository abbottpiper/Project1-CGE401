using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WinAndLoseConditions : MonoBehaviour
{
    private CountOrders countOrdersScript;
    private HealthSystem healthSystemScript;

    public Text Order;

    public float time = 10.0f;

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

        if (time <= 0)
        {
            healthSystemScript.TakeDamage();
            time = 10.0f;
        }
    }

    public void OrderOne()
    {
        if (countOrdersScript.totalCount == 4 && countOrdersScript.totalFood == 4)
        {
            Order.text = "Correct! Great Job!";
            time = 10.0f;

            countOrdersScript.totalCount = 0;
            countOrdersScript.totalFood = 0;
        }
        else
        {
            healthSystemScript.TakeDamage();
            Order.text = "Incorrect, try again.";

            countOrdersScript.totalCount = 0;
            countOrdersScript.totalFood = 0;
        }
    }

    public void OrderTwo()
    {
        if (countOrdersScript.totalCount == 4 && countOrdersScript.totalFood == 10)
        {
            Order.text = "Correct! Great Job!";
            time = 10.0f;

            countOrdersScript.totalCount = 0;
            countOrdersScript.totalFood = 0;
        }
        else
        {
            healthSystemScript.TakeDamage();
            Order.text = "Incorrect, try again.";

            countOrdersScript.totalCount = 0;
            countOrdersScript.totalFood = 0;
        }
    }

    public void OrderThree()
    {
        if (countOrdersScript.totalCount == 4 && countOrdersScript.totalFood == 9)
        {
            Order.text = "Correct! Great Job!";
            time = 10.0f;

            countOrdersScript.totalCount = 0;
            countOrdersScript.totalFood = 0;
        }
        else
        {
            healthSystemScript.TakeDamage();
            Order.text = "Incorrect, try again.";

            countOrdersScript.totalCount = 0;
            countOrdersScript.totalFood = 0;
        }
    }
}
