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

    private void Start()
    {
        ScoreText = GetComponent<Text>();
        scoreCount = 2;
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

        if (scoreCount == 3)
        {
            gameWonText.SetActive(true);
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
}
