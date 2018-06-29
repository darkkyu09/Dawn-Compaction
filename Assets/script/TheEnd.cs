using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TheEnd : MonoBehaviour {
	public GameObject PData;
	private bool Added = false;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Added == false) {
		
			PData.GetComponent<PlayerData> ().InsertStorage (6);
			Added = true;
		}


	}


	public void BTMM(){
	

			SceneManager.LoadScene ("MM");
		Debug.Log ("Level loaded");
		
	}

}
