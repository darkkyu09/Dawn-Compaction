using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaycastTest : MonoBehaviour {

	RaycastHit hit;
	float dis;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		Vector3 forward = transform.TransformDirection (Vector3.forward) * 15;
		Debug.DrawRay (transform.position, forward, Color.black);

		if(Physics.Raycast(transform.position, (forward), out hit)){

			dis = hit.distance;
			print (dis);
			print (hit.collider.gameObject.name);



				hit.transform.SendMessage("HitByRay");

		}
	}
}
