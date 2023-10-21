using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class L1ButtonFunctions : MonoBehaviour
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

    public Button OrderFour;
    public Button OrderFive;
    public Button OrderSix;
    public Button OrderSeven;
    public Button OrderEight;

    // Start is called before the first frame update
    void Start()
    {
        stopButton();
    }

    // Update is called once per frame
    void Update()
    {
        startButton();
    }

    public void stopButton()
    {
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

        OrderFour.interactable = false;
        OrderFive.interactable = false;
        OrderSix.interactable = false;
        OrderSeven.interactable = false;
        OrderEight.interactable = false;
    }

    public void startButton()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SeedsApple.interactable = true;
            SeedsOrange.interactable = true;
            SeedsBanana.interactable = true;
            SeedsBerries.interactable = true;
            SeedsWatermelon.interactable = true;

            SeedsCorn.interactable = true;
            SeedsTomato.interactable = true;
            SeedsCarrot.interactable = true;
            SeedsPotato.interactable = true;
            SeedsTurnip.interactable = true;

            OrderFour.interactable = true;
            OrderFive.interactable = true;
            OrderSix.interactable = true;
            OrderSeven.interactable = true;
            OrderEight.interactable = true;
        } 
    }
}
