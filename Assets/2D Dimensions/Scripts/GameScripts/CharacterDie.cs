using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterDie : MonoBehaviour {

	public GameObject Dimension1;
	public GameObject Dimension2;
	public GameObject Dimension3;
	public GameObject Dimension4;

	//public GameObject ParticleDeath;
	public Transform SpawnPoint; //Object where player will spawn

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	//When Player walk into "Spikes.Tag" Objects he will
	//reset his position to "SpawnPoint" object
	private void OnCollisionEnter2D(Collision2D collision){

		if (collision.collider.tag == "Spikes") {

			//Instantiate (ParticleDeath, transform.position, transform.rotation);
			transform.position = SpawnPoint.position;


			Dimension1.SetActive (true); //When player die show only dimension1
			Dimension2.SetActive (false);
			Dimension3.SetActive (false);
			Dimension4.SetActive (false);

		}
	}

}

