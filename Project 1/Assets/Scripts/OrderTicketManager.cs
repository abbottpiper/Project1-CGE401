using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class OrderTicketManager : MonoBehaviour
{
    public Image[] orderTickets; // An array of your order ticket images.
    public float enableInterval = 3f; // Time interval between enabling order tickets.
    private int currentIndex = 0; // Index of the currently enabled order ticket.

    private void Start()
    {
        StartCoroutine(EnableOrderTickets());
    }

    private IEnumerator EnableOrderTickets()
    {
        while (currentIndex < orderTickets.Length)
        {
            // Enable the current order ticket.
            orderTickets[currentIndex].enabled = true;

            // Wait for the specified enable interval.
            yield return new WaitForSeconds(enableInterval);

            // Move to the next order ticket in the array.
            currentIndex++;
        }
    }
}
