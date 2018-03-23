using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextRoom : MonoBehaviour {

	public string roomname;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {


	}

	void OnMouseDown(){
	
		SceneManager.LoadScene (roomname);
		Debug.Log ("clicked"); 
	}



}
