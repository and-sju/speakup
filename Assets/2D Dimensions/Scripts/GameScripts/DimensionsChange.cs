using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DimensionsChange : MonoBehaviour {

	public GameObject Dimension1; //Game Object with childers from Dimension1
	public GameObject Dimension2;
	public GameObject Dimension3;
	public GameObject Dimension4;
	public int DimensionHelp = 1; //Only 1 use of "help" = dimension4
	public GameObject NoMoreHelp; //If you have 0 clues, open "watch ad" panel

	public GameObject Player; //Our Character

	public bool isKeyEnabled = true; //you cant use 4 when you have 0 clues
	public Button WatchAD; //ad


	// Use this for initialization
	void Start () {

		Dimension1.SetActive (true); //at start we have only Dimension1 Active (press 1 to run dim1)
		Dimension2.SetActive (false); //If false that means it is not active, it is not visible
		Dimension3.SetActive (false);
		Dimension4.SetActive (false);
		Player.SetActive (true); //of course we have active player at start
		NoMoreHelp.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.Alpha1)){

			Dimension1.SetActive (true); //when you press "1" it makes active Dimension1 gameobject
			Dimension2.SetActive (false);
			Dimension3.SetActive (false);
			Dimension4.SetActive (false);
			Player.SetActive (true);
		}

		if(Input.GetKeyDown(KeyCode.Alpha2)){

			Dimension1.SetActive (false);
			Dimension2.SetActive (true); //if you press "2" it makes active Dimension2 GameObject
			Dimension3.SetActive (false);
			Dimension4.SetActive (false);
			Player.SetActive (true);
		}

		if (Input.GetKeyDown (KeyCode.Alpha3)) {

			Dimension1.SetActive (false);
			Dimension2.SetActive (false);
			Dimension3.SetActive (true); //if you press "3" it makes active Dimension3 GameObject
			Dimension4.SetActive (false);
			Player.SetActive (true);

		}

		//CLUES DIMENSION = Show every block 
		if (Input.GetKeyDown (KeyCode.Alpha4) && isKeyEnabled) { //isKeyEnabled check if you have clues

			Dimension1.SetActive (false); 
			Dimension2.SetActive (false);
			Dimension3.SetActive (false);
			Dimension4.SetActive (true);//if you have 1 or more clues you can open by pressing "4" a clues dimension

			DimensionHelp -= 1; //minus 1 clues after use
			Player.SetActive (false);

		}

		if (DimensionHelp == 0) { //if we have 0 clues
			isKeyEnabled = false; //disactive 4 pressing button
			NoMoreHelp.SetActive (true); //show ad texture to watch ad

		} else {
			NoMoreHelp.SetActive (false); //if we have 1 or more clues disactive ad texture
			isKeyEnabled = true; //enable "4" key pressing
		}


	}
		

	public void WatchAd(){

			//Play Add and add+1 to clues
			DimensionHelp += 1;

	}

	//Active SpawnPoint Dimension When Player Dies
	private void OnCollisionEnter2D(Collision2D collision){

		if (collision.collider.tag == "Spikes") {

			Dimension1.SetActive (true); //when player collide with "Spikes" Tagged Object. Reset position to SpawnPoint 
			Dimension2.SetActive (false); //and make only Dimension1 active
			Dimension3.SetActive (false);
			Dimension4.SetActive (false);
		}



	}


	//DIMENSION MOBILE INPUTS


	public void Dimension1Mobile(){ //Attach Dimension1Mobile to button to make it show Dimension1
		Dimension1.SetActive (true);
		Dimension2.SetActive (false);
		Dimension3.SetActive (false);
		Dimension4.SetActive (false);
		Player.SetActive (true);
	}
	public void Dimension2Mobile(){ //I am sure you can now understand what to attach to button to show Dimension2
		Dimension1.SetActive (false);
		Dimension2.SetActive (true);
		Dimension3.SetActive (false);
		Dimension4.SetActive (false);
		Player.SetActive (true);
	}
	public void Dimension3Mobile(){ //Exactly, attach Dimension3Mobile to button to show Dimension3
		Dimension1.SetActive (false);
		Dimension2.SetActive (false);
		Dimension3.SetActive (true);
		Dimension4.SetActive (false);
		Player.SetActive (true);
	}


	public void Dimension4Mobile(){ //We know what to do
		if (isKeyEnabled) {

			Dimension1.SetActive (false);
			Dimension2.SetActive (false);
			Dimension3.SetActive (false);
			Dimension4.SetActive (true);

			DimensionHelp -= 1;
			Player.SetActive (false);

		}

		if (DimensionHelp == 0) {
			isKeyEnabled = false;
			NoMoreHelp.SetActive (true);

		} else {
			NoMoreHelp.SetActive (false);
			isKeyEnabled = true;
		}

	}
	//I am sure you can understand what mobile inputs means. This is exactly the same code, but for buttons
		
}
