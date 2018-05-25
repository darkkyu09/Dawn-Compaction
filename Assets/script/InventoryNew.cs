using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class InventoryNew : MonoBehaviour {


	public Image[] SlotIcon;
	protected string[] ItemName;
	private int SlotAmount = 0;



	// Use this for initialization
	void Start () {
		SlotAmount = 0;
	}
	
	// Update is called once per frame
	void Update () {


	}

	public void AddItem(int ID){

		GameObject Data = GameObject.Find ("Database");
		GItemList DataList = Data.GetComponent<GItemList> ();

		if (SlotAmount != 20) {
			SlotIcon [SlotAmount].sprite = Resources.Load<Sprite> (DataList.ItemIcon [ID-1]);
			SlotAmount++;
		}
	}

	public void RemoveItem(int slot){
		if (SlotAmount != 0) {
			SlotIcon [SlotAmount-1].sprite = null;
			SlotAmount--;
		}



	}



}
