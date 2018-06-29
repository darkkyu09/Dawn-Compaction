using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjDestroy : MonoBehaviour {


	public GameObject PData;
	private int SlotID;
	private bool Avaliability;
	public int ItemReqID;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void HitByRay(){

		if (Input.GetMouseButtonDown (0)) {
			Debug.Log ("hitto");
			for (int i = 0; i < PData.GetComponent<PlayerData> ().StorageAmount; i++) {

				if (ItemReqID == PData.GetComponent<PlayerData> ().StorageItemID [i]) {

					Avaliability = true;
					SlotID = i;
					break;
				}
			}
			if (Avaliability == true) {

				print ("Item avaliable");
				PData.GetComponent<PlayerData> ().ClearStorage (SlotID);
				Debug.Log ("clicked"); 
				Destroy (gameObject);

			} else if (Avaliability == false) {

				print ("Item Unavaliable");

			}
		}
	}

}
