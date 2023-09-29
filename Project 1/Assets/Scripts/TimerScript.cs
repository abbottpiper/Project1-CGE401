using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimerScript : MonoBehaviour
{
    ClickedSprites clickedSpritesScript;

    public GameObject PlantSecondStage;

    private void Start()
    {
       // clickedSpritesScript = PlantSecondStage.GetComponent<ClickedSprites>();

        //PlantSecondStage.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        //if (clickedSpritesScript.mouseClick == true)
       // {
          //  PlantSecondStage.SetActive(true);
       // }
    }
}
