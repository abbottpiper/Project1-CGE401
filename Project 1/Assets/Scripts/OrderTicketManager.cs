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
