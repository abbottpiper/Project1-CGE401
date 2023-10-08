/*
Piper Abbott-Phillips
Level2Load.cs
Project 2
Code controls button function and scene loading from level1 to level2
*/
using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;
public class Level2Load : MonoBehaviour
{
	public Button yourButton;

	void Start()
	{
		Button btn = yourButton.GetComponent<Button>();
		btn.onClick.AddListener(TaskOnClick);
	}

	void TaskOnClick()
	{
		SceneManager.LoadScene("Level2", LoadSceneMode.Single);
	}
}