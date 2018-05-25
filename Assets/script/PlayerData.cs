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
		
	}


	public void ClearStorage(int SlotID){

		if (StorageAmount != 0) {
			Inv.GetComponent<InventoryNew> ().RemoveItem (SlotID);
		
			for (int z = SlotID; z < StorageAmount; z++) {
		
				StorageItemID [z] = StorageItemID [z + 1];
			}
			StorageAmount--;
		}
	}


	public void InsertStorage(int ItemID){
	
		if (StorageAmount < 20) {
		
			StorageItemID [StorageAmount] = ItemID;
			Inv.GetComponent<InventoryNew> ().AddItem (StorageItemID[StorageAmount]);
			StorageAmount++;
		}
	}


}

