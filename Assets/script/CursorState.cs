using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class CursorState : MonoBehaviour {

	public int C_State; // 99 is default
	public Image ThisCursor;

	// Use this for initialization
	void Start () {
		C_State = 99;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void CursorDefault(){
	
		ThisCursor.sprite = null;
		C_State = 99;
	}

	void CursorItemEquip(int ItemID){
	
		GameObject Data = GameObject.Find ("Database");
		GItemList DataList = Data.GetComponent<GItemList> ();

		ThisCursor.sprite = Resources.Load<Sprite> (DataList.ItemIcon [ItemID-1]);
		C_State = ItemID;
	}







}
