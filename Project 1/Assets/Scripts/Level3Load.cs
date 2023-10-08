/*
Piper Abbott-Phillips
Level3Load.cs
Project 2
Code controls button function and scene loading from level2 to level3
*/
using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;
public class Level3Load : MonoBehaviour
{
	public Button yourButton;

	void Start()
	{
		Button btn = yourButton.GetComponent<Button>();
		btn.onClick.AddListener(TaskOnClick);
	}

	void TaskOnClick()
	{
		SceneManager.LoadScene("Level3", LoadSceneMode.Single);
	}
}