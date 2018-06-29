using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextRoom : MonoBehaviour {

	public string roomname;
	public GameObject PData;
	private int SlotID;
	private bool Avaliability;


	// Use this for initialization
	void Start () {


	
	}
	
	// Update is called once per frame
	void Update () {
		


	}

	void HitByRay(){

		if (Input.GetMouseButtonDown (0)) {
			Debug.Log ("hitto");
		for (int i = 0; i < PData.GetComponent<PlayerData> ().StorageAmount; i++) {

			if (1 == PData.GetComponent<PlayerData> ().StorageItemID [i]) {

				Avaliability = true;
				SlotID = i;
				break;
			}
		}
		if (Avaliability == true) {

			print ("Item avaliable");
			PData.GetComponent<PlayerData> ().ClearStorage (SlotID);
				SceneManager.LoadScene (roomname);
				Debug.Log ("clicked"); 

		} else if (Avaliability == false) {

			print ("Item Unavaliable");

		}
		}
	}



}
