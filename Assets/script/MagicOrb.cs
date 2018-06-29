using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MagicOrb : MonoBehaviour {

	public GameObject NextOrb;
	public GameObject PData;
	private int SlotID;
	public int ItemReqID;
	private bool Avaliability;
	public bool CurrentObj;
	public bool LastOrb;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void HitByRay(){
	
		if (Input.GetMouseButtonDown (0) && CurrentObj == true) {
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
				Debug.Log ("clicked"); 
				CurrentObj = false;
				Destroy (gameObject);
				if (LastOrb == false) {
					NextOrb.GetComponent<MagicOrb> ().CurrentObj = true;
				}

			} else if (Avaliability == false) {

				print ("Item Unavaliable");

			}
		}

	}




}
