using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WinAndLoseConditions : MonoBehaviour
{
    public CountOrders countOrdersScript;
    public HealthSystem healthSystemScript;

    public float time = 15.0f;

    public GameObject CorrectOrderText;
    public GameObject WrongOrderText;

    public GameObject GameWonText;

    IEnumerator DelayedCloseCorrect()
    {
        yield return new WaitForSeconds(2.0f);

        CorrectOrderText.SetActive(false);
    }

    IEnumerator DelayedCloseWrong()
    {
        yield return new WaitForSeconds(2.0f);

        WrongOrderText.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
       // if (time > 0)
        //{
           // time -= Time.deltaTime;
       // }
        //else
       // {
         //   time = 15.0f;
          //  healthSystemScript.TakeDamage();
        //}
    }

    public void OrderOne()
    {
        if (countOrdersScript.totalFood == 4)
        {
            CorrectOrderText.SetActive(true);
            StartCoroutine(DelayedCloseCorrect());

             time = 15.0f;

            countOrdersScript.totalCount = 0;
            countOrdersScript.totalFood = 0;

            Destroy(GameObject.FindWithTag("OrderOne"));
        }
        else
        {
            healthSystemScript.TakeDamage();

            WrongOrderText.SetActive(true);
            StartCoroutine(DelayedCloseWrong());

            countOrdersScript.totalCount = 0;
            countOrdersScript.totalFood = 0;
        }
    }

    public void OrderTwo()
    {
        if (countOrdersScript.totalFood == 10)
        {
            CorrectOrderText.SetActive(true);
            StartCoroutine(DelayedCloseCorrect());

            // time = 15.0f;

            countOrdersScript.totalCount = 0;
            countOrdersScript.totalFood = 0;

            Destroy(GameObject.FindWithTag("OrderTwo"));
        }
        else
        {
            healthSystemScript.TakeDamage();

            WrongOrderText.SetActive(true);
            StartCoroutine(DelayedCloseWrong());

            countOrdersScript.totalCount = 0;
            countOrdersScript.totalFood = 0;
        }
    }

    public void OrderThree()
    {
        if (countOrdersScript.totalFood == 9)
        {
            CorrectOrderText.SetActive(true);
            StartCoroutine(DelayedCloseCorrect());

            // time = 15.0f;

            countOrdersScript.totalCount = 0;
            countOrdersScript.totalFood = 0;

            Destroy(GameObject.FindWithTag("OrderThree"));
        }
        else
        {
            healthSystemScript.TakeDamage();

            WrongOrderText.SetActive(true);
            StartCoroutine(DelayedCloseWrong());

            countOrdersScript.totalCount = 0;
            countOrdersScript.totalFood = 0;
        }
    }
}
