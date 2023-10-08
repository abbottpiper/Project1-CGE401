/*
Denver Heneghan
HealthSystem.cs
Project 2
This script keeps track of the health of the player. It also sets gameOver to false. It makes sure that the health on screen is set to the
max amount of health allowed. In this case, it is set to three. Then it switches a full heart to an empty heart depending on the players 
health. If health reaches 0, then gameOver is set to true. This causes the gameOver text to appear, and tells the player to restart. This script
also allows the player to restart by pressing R if all hearts have been lost. The void takeDamage is also initialized here so it can be called
in other scripts.
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HealthSystem : MonoBehaviour
{
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

            //Press R to restart if game is over
            if (Input.GetKeyDown(KeyCode.R))
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
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
