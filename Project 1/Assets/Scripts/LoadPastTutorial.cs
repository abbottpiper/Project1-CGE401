/*
Piper Abbott-Phillips
LoadPastTutorial.cs
Project 2
Code controls button function and scene loading from main menu to game scene
*/
using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;
public class LoadPastTutorial : MonoBehaviour {
	public Button yourButton;

	void Start () {
		Button btn = yourButton.GetComponent<Button>();
		btn.onClick.AddListener(TaskOnClick);
	}

	void TaskOnClick(){
		SceneManager.LoadScene("GardenScene", LoadSceneMode.Single);
	}
}