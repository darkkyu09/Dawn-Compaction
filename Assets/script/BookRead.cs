using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BookRead : MonoBehaviour {

	public GameObject contentbook;
	//public GameObject FirstOrb;
	private bool isOpen;
	private bool isFirstTime = true;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		if (contentbook.activeSelf == true && Input.GetMouseButtonDown(0)) {
		
			contentbook.SetActive(false);
			isOpen = false;
		}

	}

	void HitByRay(){
	
		if (Input.GetMouseButtonDown (0)) {
			
			if (isFirstTime == true) {
			
				GameObject.Find("1").GetComponent<MagicOrb> ().CurrentObj = true;
				isFirstTime = false;
			}
			contentbook.SetActive(true);
			isOpen = true;
		}
	}



}
