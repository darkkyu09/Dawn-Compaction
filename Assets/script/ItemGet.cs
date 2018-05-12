using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemGet : MonoBehaviour {

	public GameObject PData;
	public int ItemID;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {


	}


	void HitByRay(){

		Debug.Log ("hitto");
		if (Input.GetMouseButtonDown (0)) {

			PData.GetComponent<PlayerData> ().InsertStorage (ItemID);
			gameObject.SetActive (false);
		}
	}
}
