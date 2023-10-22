/*
Denver Heneghan
HealthSystem.cs
Project 2
This script keeps track of the health of the player. It also sets gameOver to false. It makes sure that the health on screen is set to the
max amount of health allowed. In this case, it is set to three. Then it switches a full heart to an empty heart depending on the players 
health. If health reaches 0, then gameOver is set to true. This causes the gameOver text to appear, and tells the player to restart. This script
also allows the player to restart by pressing R if all hearts have been lost. The void takeDamage is also initialized here so it can be called
in other scripts. Time.timeScale is also added to this script. If the hearts reach 0, the time will be set to 0, which stops the timer. Once the
scene is restarted, it is reset back to one, and the timer starts counting down again. This script also sets all of the seed buttons and order
ticket buttons to no longer be intractable when the hearts reach zero. This stops the player from playing after the game is over.
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HealthSystem : MonoBehaviour
{
    public Button SeedsApple;
    public Button SeedsOrange;
    public Button SeedsBanana;
    public Button SeedsBerries;
    public Button SeedsWatermelon;

    public Button SeedsCorn;
    public Button SeedsTomato;
    public Button SeedsPotato;
    public Button SeedsTurnip;
    public Button SeedsCarrot;

    public Button OrderOne;
    public Button OrderTwo;
    public Button OrderThree;
    public Button OrderFour;
    public Button OrderFive;
    public Button OrderSix;
    public Button OrderSeven;
    public Button OrderEight;
    public Button OrderNine;
    public Button OrderTen;
    public Button OrderEleven;
    public Button OrderTwelve;
    public Button OrderThirteen;
    public Button OrderFourteen;
    public Button OrderFifteen;

    public int health;
    public int maxHealth;

    public List<Image> hearts;
    public Sprite fullHeart;
    public Sprite emptyHeart;

    public bool gameOver = false;

    public GameObject gameOverText;

    void Update()
    {
        //If health is somehow more than max health, set health to max health
        if (health > maxHealth)
        {
            health = maxHealth;
        }


        for (int i = 0; i < hearts.Count; i++)
        {
            //Display full or empty heart sprite based on current health
            if (i < health)
            {
                hearts[i].sprite = fullHeart;
            }
            else
            {
                hearts[i].sprite = emptyHeart;
            }

            //Show the number of hearts equal to current max health
            if (i < maxHealth)
            {
                hearts[i].enabled = true;
            }
            else
            {
                hearts[i].enabled = false;
            }
        }

        if (health <= 0)
        {
            gameOver = true;
            gameOverText.SetActive(true);
            Time.timeScale = 0;

            SeedsApple.interactable = false;
            SeedsOrange.interactable = false;
            SeedsBanana.interactable = false;
            SeedsBerries.interactable = false;
            SeedsWatermelon.interactable = false;

            SeedsTomato.interactable = false;
            SeedsCorn.interactable = false;
            SeedsCarrot.interactable = false;
            SeedsPotato.interactable = false;
            SeedsTurnip.interactable = false;

            OrderOne.interactable = false;
            OrderTwo.interactable = false;
            OrderThree.interactable = false;
            OrderFour.interactable = false;
            OrderFive.interactable = false;
            OrderSix.interactable = false;
            OrderSeven.interactable = false;
            OrderEight.interactable = false;
            OrderNine.interactable = false;
            OrderTen.interactable = false;
            OrderEleven.interactable = false;
            OrderTwelve.interactable = false;
            OrderThirteen.interactable = false;
            OrderFourteen.interactable = false;
            OrderFifteen.interactable = false;

            //Press R to restart if game is over
            if (Input.GetKeyDown(KeyCode.R))
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
                Time.timeScale = 1;
            }
        }

    }

    public void TakeDamage()
    {
        health--;
    }

    public void AddMaxHealth()
    {
        maxHealth++;
    }
}
