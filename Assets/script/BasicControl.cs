﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BasicControl : MonoBehaviour {

	public GameObject Inv;
	private bool InvStatus;
	public bool InvStatusInfo;

	// Use this for initialization
	void Start () {



		Inv.SetActiveRecursively(false);
		InvStatus = false;
		InvStatusInfo = InvStatus;
		Cursor.visible = false;

	}
	
	// Update is called once per frame
	void Update ()
	{
		
		if (Input.GetKeyDown (KeyCode.I)) {
			if (InvStatus == false) {
				Inv.SetActiveRecursively (true);
				InvStatus = true;
				Cursor.visible = true;
			}else if (InvStatus == true) {
				Inv.SetActiveRecursively(false);
				InvStatus = false;
				Cursor.visible = false;
			}
			InvStatusInfo = InvStatus;

		} 


	}
}
