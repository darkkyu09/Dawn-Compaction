using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraPlayerVision : MonoBehaviour {

	private float s_Horizontal = 2f;
	private float s_Vertical = 2f;
	private float yaw = 0f;
	private float pitch = 0f;



	// Use this for initialization
	void Start () {
		
		//Cursor.visible = false;
	}
	
	// Update is called once per frame
	void Update () {

		yaw += s_Horizontal * Input.GetAxis ("Mouse X");
		pitch -= s_Vertical * Input.GetAxis ("Mouse Y");

		transform.eulerAngles = new Vector3 (pitch, yaw, 0f);

	}


}
