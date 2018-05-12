using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerData : MonoBehaviour {

	public int StorageAmount = 0;
	public int[] StorageItemID;
	public GameObject Inv;

	// Use this for initialization
	void Start () {


		
	}
	
	// Update is called once per frame
	void Update () {

		if (GameObject.Find ("Player").GetComponent<BasicControl> ().InvStatusInfo == true) {
			if (StorageAmount < 20) {
				for (int i = 0; i < StorageAmount + 1; i++) {
		
			
					Inv.GetComponent<InventoryNew> ().AddItem (i);
				
				}
			}
		}
	}


	public void ClearStorage(int SlotID){
		if (GameObject.Find ("Player").GetComponent<BasicControl> ().InvStatusInfo == true) {
			Inv.GetComponent<InventoryNew> ().RemoveItem (SlotID);
		}
		for (int z = SlotID; z < StorageAmount; z++) {
		
			StorageItemID [z] = StorageItemID [z + 1];
		}
	}


	public void InsertStorage(int ItemID){
	
		if (StorageAmount < 20) {
		
			StorageItemID [StorageAmount] = ItemID;
			StorageAmount++;
		}
	}


}

