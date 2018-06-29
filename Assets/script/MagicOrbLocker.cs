using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MagicOrbLocker : MonoBehaviour {

	public GameObject Orb1;
	public GameObject Orb2;
	public GameObject Orb3;
	public GameObject Target;

	// Use this for initialization
	void Start () {
	


	}
	
	// Update is called once per frame
	void Update () {

		if (Orb1 == null && Orb2 == null && Orb3 == null) {
			
			Target.GetComponent<NextRoomBlocked> ().unlock = true;
		}
	}

}
