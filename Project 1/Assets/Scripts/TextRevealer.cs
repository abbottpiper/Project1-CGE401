using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class TextRevealer : MonoBehaviour
{
    public Text textComponent;
    public float revealSpeed = 0.1f;

    private string fullText;
    private string currentText = "";

    private void Start()
    {
        textComponent = GetComponent<Text>();
        fullText = textComponent.text;
        textComponent.text = "";
        StartCoroutine(RevealText());
    }

    private IEnumerator RevealText()
    {
        for (int i = 0; i < fullText.Length; i++)
        {
            currentText += fullText[i];
            textComponent.text = currentText;
            yield return new WaitForSeconds(revealSpeed);
        }
    }
}
