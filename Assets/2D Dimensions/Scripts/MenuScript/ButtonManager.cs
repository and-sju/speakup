using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class ButtonManager : MonoBehaviour {

	public GameObject NoMoreHelp;

	// Use this for initialization
	public void NewGameBtn(string newGameLevel){


		SceneManager.LoadScene (newGameLevel);
	}

	public void ExitGameBtn(){

		Application.Quit ();
	}

	public void ResumeGameBtn(){

		NoMoreHelp.SetActive (false);
	}

	public void ShowAdBtn(){

		//showAD
	}

}