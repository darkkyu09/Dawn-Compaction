using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemRemoveTest : MonoBehaviour {

	public GameObject PData;
	public int ItemID;
	private int SlotID;
	private bool Avaliability;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void HitByRay ()
	{

		Debug.Log ("hitto");
		if (Input.GetMouseButtonDown (0)) {

			for (int i = 0; i < PData.GetComponent<PlayerData> ().StorageAmount; i++) {
			
				if (ItemID == PData.GetComponent<PlayerData> ().StorageItemID [i]) {
				
					Avaliability = true;
					SlotID = i;
					break;
				}
			}
			if (Avaliability == true) {
			
				print ("Item avaliable");

			} else if (Avaliability == false) {
			
				print ("Item Unavaliable");

			}

			PData.GetComponent<PlayerData> ().ClearStorage (SlotID);

		}


	}
}
