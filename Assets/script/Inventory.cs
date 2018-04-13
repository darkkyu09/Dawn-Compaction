using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour
{
	public static Inventory inventoryScript;

	private List<string> items = new List<string>();
	public GameObject inventory;
	public List<GameObject> iconList = new List<GameObject>();
	protected int Slot = 1;

	void Awake(){
		inventoryScript = this;
		foreach (Transform child in inventory.transform)
		{
			iconList.Add(child.gameObject);
		}
	}

	// Use this for initialization
	void Start ()
	{
		AddItemInv ("Tenga");
	}
	
	// Update is called once per frame
	void Update () {
	

	}


	public void AddItemInv(string itemName)
	{
		Debug.Log ("OI");
		if (Slot < 21)
		{
			items.Add (itemName);
			GameObject go = new GameObject ();

			if (iconList [Slot].transform.childCount == 0) {
				go = Instantiate (new GameObject ());
				go.transform.SetParent (iconList [Slot-1].transform);
			} else {
				go = iconList [Slot-1].transform.GetChild (0).gameObject;
			}

			go.transform.position = iconList [Slot].transform.position;

			Debug.Log ("Test");
			go.AddComponent<Image> ().sprite = Resources.Load (itemName) as Sprite;

			Slot = Slot + 1;
		}
	}

	public void RemoveItemInv(int slot)
	{
		items.RemoveAt (slot);
		iconList.RemoveAt(slot);
	}

	public void RemoveItemInv(string itemName)
	{
		items.Remove (itemName);
		foreach (GameObject go in iconList)
		{
			if (go.name.Equals (itemName))
				iconList.Remove (go);
		}

		for (int i = 0; i < iconList.Count; i++)
		{
			GameObject go = iconList [i];

			if (go.name.Equals (itemName))
				iconList.Remove (go);
		}
	}

}

