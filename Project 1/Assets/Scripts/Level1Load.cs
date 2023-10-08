/*
Piper Abbott-Phillips
Level1Load.cs
Project 2
Code controls button function and scene loading from gardenscene to level1
*/
using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;
public class Level1Load : MonoBehaviour
{
	public Button yourButton;

	void Start()
	{
		Button btn = yourButton.GetComponent<Button>();
		btn.onClick.AddListener(TaskOnClick);
	}

	void TaskOnClick()
	{
		SceneManager.LoadScene("Level1", LoadSceneMode.Single);
	}
}