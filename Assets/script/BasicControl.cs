using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicControl : MonoBehaviour {

	public float speed = 3f;
	private float rotation_x;
	private float rotation_z;

	// Use this for initialization
	void Start () {

		rotation_x = GetComponent<CameraPlayerVision> ().GetComponent<Transform> ().eulerAngles.x;
		rotation_z = GetComponent<CameraPlayerVision> ().GetComponent<Transform> ().eulerAngles.z;



	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetMouseButton (0)) {
		
			transform.Translate (Vector3.forward * Time.deltaTime * speed);
		}


	}
}
