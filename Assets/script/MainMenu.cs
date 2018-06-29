using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class MainMenu : MonoBehaviour {

	private bool isFullscreen;
	private Resolution Res;
	public GameObject setting;


	void Start () {

		isFullscreen = Screen.fullScreen;

	}

	//Main Menu
	public void StartGame(){
		SceneManager.LoadScene ("Room_1");
	}

	public void ClickCheck(){
	
		Debug.Log ("Clicked");
	}

	public void Setting(){
		if (setting.activeSelf == false) {
			setting.SetActive (true);
		}
	}

	public void ExitGame(){
	
		Application.Quit ();
	}

	//Option
	public void FSSetting(){
		
		if (isFullscreen == false) {
		
			Screen.fullScreen = true;
			isFullscreen = true;
		}else if (isFullscreen == true){
			Screen.fullScreen = false;
			isFullscreen = false;
		}
	}

	public void SettingClose(){
		if (setting.activeSelf == true) {
		
			setting.SetActive (false);
		}
	}
}
