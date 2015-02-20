using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class UIMangerScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	// Play Button Click Event
	public void OnPlayButtonClick(){
		Debug.Log("Play Button clicked");
	}

	//Setting  Button Click

	public void OnSettingsButtonClick(Canvas can){
		Debug.Log("Settings Button Click");
	}

	// exit button click event
	public void OnExitbuttonClick(){
		Debug.Log("Exit Button click");
	}
}
