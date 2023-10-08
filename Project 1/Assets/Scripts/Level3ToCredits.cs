/*
Piper Abbott-Phillips
Level3ToCredits.cs
Project 2
Code controls button function and scene loading from Level3 to the credits
*/
using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;
public class Level3ToCredits : MonoBehaviour
{
	public Button yourButton;

	void Start()
	{
		Button btn = yourButton.GetComponent<Button>();
		btn.onClick.AddListener(TaskOnClick);
	}

	void TaskOnClick()
	{
		SceneManager.LoadScene("Credits", LoadSceneMode.Single);
	}
}