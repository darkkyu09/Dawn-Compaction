using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextRoomBlocked : MonoBehaviour {

	public GameObject Target;
	public string roomname;
	public bool unlock;
	public bool UseLock = false;

	// Use this for initialization
	void Start () {
		//Target = GameObject.Find ("Woodplanks");
	}
	
	// Update is called once per frame
	void Update () {


	}


	void HitByRay(){
	
		if (Input.GetMouseButtonDown (0)) {
			if (UseLock == true) {
				if (unlock == true) {
			
					SceneManager.LoadScene (roomname);
				} else if (unlock == false) {
			
					print ("door is locked");
				}
			}
			if (Target == null) {
				SceneManager.LoadScene (roomname);
			} else if (Target != null) {
		
				print ("Door is blocked");
			}
		}
	
	}
}
