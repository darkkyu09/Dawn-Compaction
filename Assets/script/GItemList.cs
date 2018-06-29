using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GItemList : MonoBehaviour {

	public int[] ItemID;
	public string[] ItemName;
	public string[] ItemIcon;



	// Use this for initialization
	void Start () {


		// Icon list
		ItemIcon[0] = "UI/Icon/Key_ic";
		ItemIcon[1] = "UI/Icon/Axe_ic";
		ItemIcon[2] = "UI/Icon/MoonSword_ic";
		ItemIcon[3] = "UI/Icon/Sword_ic";
		ItemIcon[4] = "UI/Icon/Spear_ic";
		ItemIcon[5] = "UI/Icon/ClockTT_ic";
	}


}
