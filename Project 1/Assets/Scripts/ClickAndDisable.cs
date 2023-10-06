
/*
Piper Abbott-Phillips
ClickAndDisable.cs
Project 2
Code tracks players mouse position on left click, and disabled object that is clicked on
*/
using UnityEngine;

public class ClickAndDisable : MonoBehaviour
{
    public float moveSpeed = 500f; 
    private Vector3 targetPosition;

    private void Start()
    {
        
        MoveToRandomPosition();
    }

    private void Update()
    {
        
        if (Input.GetMouseButtonDown(0))
        {
            
            Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            
            RaycastHit2D hit = Physics2D.Raycast(mousePosition, Vector2.zero);

           
            if (hit.collider != null)
            {
                
                if (hit.collider.gameObject == gameObject)
                {
                    
                    gameObject.SetActive(false);
                }
            }
        }

        
        transform.position = Vector3.MoveTowards(transform.position, targetPosition, moveSpeed * Time.deltaTime);

       
        if (Vector3.Distance(transform.position, targetPosition) < 0.1f)
        {
           
            MoveToRandomPosition();
        }
    }

    private void MoveToRandomPosition()
    {
        float randomX = Random.Range(-232f, 232f);
        float randomY = Random.Range(-120f, 120f);
        targetPosition = new Vector3(randomX, randomY, 0f);
    }
}
