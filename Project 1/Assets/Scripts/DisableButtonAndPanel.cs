using UnityEngine;
using UnityEngine.UI;

public class DisableButtonAndPanel : MonoBehaviour
{
    public Button button;
    public GameObject panel;

    private void Start()
    {
        // Get a reference to the Button component
        button = GetComponent<Button>();

        // Attach a listener to the button's click event
        button.onClick.AddListener(DisableButtonAndPanelOnClick);
    }

    private void DisableButtonAndPanelOnClick()
    {
        // Disable the button
        button.interactable = false;

        // Disable the panel
        panel.SetActive(false);
    }
}
