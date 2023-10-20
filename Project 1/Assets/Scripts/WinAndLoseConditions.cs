/*
Denver Heneghan
WinAndLoseConditions.cs
Project 2
This script keeps track of the win conditions and loss conditions. It also keeps track of the score and the orders. There are fifteen orders
and each is applied to a ticket object in unity. If an order is called by clicking a button, the void will check if the foodScore is equal
to a specific number assigned to that order. If the food score has been added up to equal that number, then the object is sought out by its
tag and destroyed. Next, the score goes up by one, and totalFood and totalCount are reset to zero. If the foodScore does not match the number 
listed, the void will call the takeDamage void from the HealthSystem script and the player will lose a life. It will also set the wrongOrder
text to true so the text is visible to the player. Then an IEnumerator is called, which waits 2 seconds then hides the text from the player. 
This makes sure the text is only on screen for two seconds. Lastly, it will also set totalFood and totalCount to 0. This script also displays
the score. Each level has a different score to reach, so each level has its own void to call. Each level checks if the score in their
a specific void has been reached. If the score is reached in that level, then the You Win text is displayed and a next button will be moved
into view of the player. Clicking the next button will bring the player to the next level.
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

    public int scoreCount = 0;

    public Button NextButton;

    IEnumerator DelayedCloseWrong()
    {
        yield return new WaitForSeconds(2.0f);

        WrongOrderText.SetActive(false);
    }

    public void tScore()
    {
        if (scoreCount == 3)
        {
            gameWonText.SetActive(true);
            NextButton.gameObject.transform.localPosition = new Vector3(-45, -5, 0);
            Time.timeScale = 0;
        }
    }

    public void oneScore()
    {
        if (scoreCount == 5)
        {
            gameWonText.SetActive(true);
            NextButton.gameObject.transform.localPosition = new Vector3(-45, -5, 0);
            Time.timeScale = 0;
        }
    }

    public void twoScore()
    {
        if (scoreCount == 10)
        {
            gameWonText.SetActive(true);
            NextButton.gameObject.transform.localPosition = new Vector3(-45, -5, 0);
            Time.timeScale = 0;

        }
    }

    public void threeScore()
    {
        if (scoreCount == 15)
        {
            gameWonText.SetActive(true);
            NextButton.gameObject.transform.localPosition = new Vector3(-45, -5, 0);
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
