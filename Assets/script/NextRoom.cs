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

	void HitByRay(){
	
		Debug.Log ("hitto");
		if (Input.GetMouseButtonDown (0)) {
		
			SceneManager.LoadScene (roomname);
			Debug.Log ("clicked"); 
		}
	}



}
