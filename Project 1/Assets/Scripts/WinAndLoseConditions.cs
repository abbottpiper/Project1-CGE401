/*
Denver Heneghan
WinAndLoseConditions.cs
Project 2

*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class WinAndLoseConditions : MonoBehaviour
{
    public CountOrders countOrdersScript;
    public HealthSystem healthSystemScript;
    public Timer timerScript;

    public GameObject WrongOrderText;

    public GameObject gameWonText;

    public Text ScoreText;

    public static int scoreCount;

    public Button NextButton;

    private void Start()
    {
        NextButton.gameObject.SetActive(false);

        ScoreText = GetComponent<Text>();

        scoreCount = 0;
    }

    IEnumerator DelayedCloseWrong()
    {
        yield return new WaitForSeconds(2.0f);

        WrongOrderText.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        ScoreText.text = "Score: " + scoreCount;
    }

    public void tScore()
    {
        if (scoreCount == 3)
        {
            gameWonText.SetActive(true);
            NextButton.gameObject.SetActive(true);
        }
    }

    public void oneScore()
    {
        if (scoreCount == 5)
        {
            gameWonText.SetActive(true);
            NextButton.gameObject.SetActive(true);
        }
    }

    public void twoScore()
    {
        if (scoreCount == 10)
        {
            gameWonText.SetActive(true);
            NextButton.gameObject.SetActive(true);
        }
    }

    public void threeScore()
    {
        if (scoreCount == 15)
        {
            gameWonText.SetActive(true);
            NextButton.gameObject.SetActive(true);
        }
    }

    public void OrderOne()
    {
        if (countOrdersScript.totalFood == 4)
        {
            scoreCount++;

            countOrdersScript.totalCount = 0;
            countOrdersScript.totalFood = 0;

            Destroy(GameObject.FindGameObjectWithTag("OrderOne"));
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
            scoreCount++;

            countOrdersScript.totalCount = 0;
            countOrdersScript.totalFood = 0;

            Destroy(GameObject.FindGameObjectWithTag("OrderTwo"));
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
            scoreCount++;

            countOrdersScript.totalCount = 0;
            countOrdersScript.totalFood = 0;

            Destroy(GameObject.FindGameObjectWithTag("OrderThree"));
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

    public void OrderFour()
    {
        if (countOrdersScript.totalFood == 32)
        {
            scoreCount++;

            countOrdersScript.totalCount = 0;
            countOrdersScript.totalFood = 0;

            Destroy(GameObject.FindGameObjectWithTag("OrderFour"));
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

    public void OrderFive()
    {
        if (countOrdersScript.totalFood == 27)
        {
            scoreCount++;

            countOrdersScript.totalCount = 0;
            countOrdersScript.totalFood = 0;

            Destroy(GameObject.FindGameObjectWithTag("OrderFive"));
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


    public void OrderSix()
    {
        if (countOrdersScript.totalFood == 29)
        {
            scoreCount++;

            countOrdersScript.totalCount = 0;
            countOrdersScript.totalFood = 0;

            Destroy(GameObject.FindGameObjectWithTag("OrderSix"));
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


    public void OrderSeven()
    {
        if (countOrdersScript.totalFood == 20)
        {
            scoreCount++;

            countOrdersScript.totalCount = 0;
            countOrdersScript.totalFood = 0;

            Destroy(GameObject.FindGameObjectWithTag("OrderSeven"));
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


    public void OrderEight()
    {
        if (countOrdersScript.totalFood == 17)
        {
            scoreCount++;

            countOrdersScript.totalCount = 0;
            countOrdersScript.totalFood = 0;

            Destroy(GameObject.FindGameObjectWithTag("OrderEight"));
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


    public void OrderNine()
    {
        if (countOrdersScript.totalFood == 28)
        {
            scoreCount++;

            countOrdersScript.totalCount = 0;
            countOrdersScript.totalFood = 0;

            Destroy(GameObject.FindGameObjectWithTag("OrderNine"));
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


    public void OrderTen()
    {
        if (countOrdersScript.totalFood == 8)
        {
            scoreCount++;

            countOrdersScript.totalCount = 0;
            countOrdersScript.totalFood = 0;

            Destroy(GameObject.FindGameObjectWithTag("OrderTen"));
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

    public void OrderEleven()
    {
        if (countOrdersScript.totalFood == 18)
        {
            scoreCount++;

            countOrdersScript.totalCount = 0;
            countOrdersScript.totalFood = 0;

            Destroy(GameObject.FindGameObjectWithTag("OrderEleven"));
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

    public void OrderTwelve()
    {
        if (countOrdersScript.totalFood == 31)
        {
            scoreCount++;

            countOrdersScript.totalCount = 0;
            countOrdersScript.totalFood = 0;

            Destroy(GameObject.FindGameObjectWithTag("OrderTwelve"));
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

    public void OrderThirteen()
    {
        if (countOrdersScript.totalFood == 40)
        {
            scoreCount++;

            countOrdersScript.totalCount = 0;
            countOrdersScript.totalFood = 0;

            Destroy(GameObject.FindGameObjectWithTag("OrderThirteen"));
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

    public void OrderFourteen()
    {
        if (countOrdersScript.totalFood == 30)
        {
            scoreCount++;

            countOrdersScript.totalCount = 0;
            countOrdersScript.totalFood = 0;

            Destroy(GameObject.FindGameObjectWithTag("OrderFourteen"));
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

    public void OrderFifteen()
    {
        if (countOrdersScript.totalFood == 22)
        {
            scoreCount++;

            countOrdersScript.totalCount = 0;
            countOrdersScript.totalFood = 0;

            Destroy(GameObject.FindGameObjectWithTag("OrderFifteen"));
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
