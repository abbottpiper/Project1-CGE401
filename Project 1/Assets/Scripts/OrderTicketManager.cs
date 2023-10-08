/*
Denver Heneghan
OrderTicketManager.cs
Project 2
This code was meant to spawn the tickets at certain intervals. After a certain amount of seconds had passed, the tickets would appear.
This code was not used in the final version of the game.
 */

using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class OrderTicketManager : MonoBehaviour
{
    public Image[] orderTickets; 
    public float enableInterval = 3f; 
    private int currentIndex = 0; 

    private void Start()
    {
        StartCoroutine(EnableOrderTickets());
    }

    private IEnumerator EnableOrderTickets()
    {
        while (currentIndex < orderTickets.Length)
        {
           
            orderTickets[currentIndex].enabled = true;

            
            yield return new WaitForSeconds(enableInterval);

            
            currentIndex++;
        }
    }
}
