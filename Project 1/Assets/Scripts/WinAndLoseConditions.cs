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
    public Text ScoreText1;
    public Text ScoreText2;
    public Text ScoreText3;

    public static int scoreCountT;
    public static int scoreCount1;
    public static int scoreCount2;
    public static int scoreCount3;


    private void Start()
    {
        ScoreText = GetComponent<Text>();
        ScoreText1 = GetComponent<Text>();
        ScoreText2 = GetComponent<Text>();
        ScoreText3 = GetComponent<Text>();

        scoreCountT = 0;
        scoreCount1 = 0;
        scoreCount2 = 0;
        scoreCount3 = 0;
    }

    IEnumerator DelayedCloseWrong()
    {
        yield return new WaitForSeconds(2.0f);

        WrongOrderText.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        ScoreText.text = "Score: " + scoreCountT;
        ScoreText1.text = "Score: " + scoreCount1;
        ScoreText2.text = "Score: " + scoreCount2;
        ScoreText3.text = "Score: " + scoreCount3;

        if (scoreCountT == 3)
        {
            gameWonText.SetActive(true);
        }

        if (scoreCount1 == 5)
        {
            gameWonText.SetActive(true);
        }

        if (scoreCount2 == 10)
        {
            gameWonText.SetActive(true);
        }

        if (scoreCount3 == 15)
        {
            gameWonText.SetActive(true);
        }
    }

    public void OrderOne()
    {
        if (countOrdersScript.totalFood == 4)
        {
            scoreCountT++;
            scoreCount1++;
            scoreCount2++;
            scoreCount3++;

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
            scoreCountT++;
            scoreCount1++;
            scoreCount2++;
            scoreCount3++;

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
            scoreCountT++;
            scoreCount1++;
            scoreCount2++;
            scoreCount3++;

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
            scoreCountT++;
            scoreCount1++;
            scoreCount2++;
            scoreCount3++;

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
            scoreCountT++;
            scoreCount1++;
            scoreCount2++;
            scoreCount3++;

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
            scoreCountT++;
            scoreCount1++;
            scoreCount2++;
            scoreCount3++;

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
            scoreCountT++;
            scoreCount1++;
            scoreCount2++;
            scoreCount3++;

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
            scoreCountT++;
            scoreCount1++;
            scoreCount2++;
            scoreCount3++;

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
            scoreCountT++;
            scoreCount1++;
            scoreCount2++;
            scoreCount3++;

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
            scoreCountT++;
            scoreCount1++;
            scoreCount2++;
            scoreCount3++;

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
            scoreCountT++;
            scoreCount1++;
            scoreCount2++;
            scoreCount3++;

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
            scoreCountT++;
            scoreCount1++;
            scoreCount2++;
            scoreCount3++;

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
            scoreCountT++;
            scoreCount1++;
            scoreCount2++;
            scoreCount3++;

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
            scoreCountT++;
            scoreCount1++;
            scoreCount2++;
            scoreCount3++;

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
            scoreCountT++;
            scoreCount1++;
            scoreCount2++;
            scoreCount3++;

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
