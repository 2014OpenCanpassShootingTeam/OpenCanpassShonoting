using UnityEngine;
using System.Collections;

public class TitleScript : MonoBehaviour {

	public GUIStyle titleStyle;
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
		if (Input.GetKeyDown(KeyCode.Space)){
			Application.LoadLevel("Main");
		}
		
	}
	
	
	void OnGUI(){
		GUI.Label (new Rect(100, Screen.height/2 - 50, 100, 30), "SHOOTING GAME", titleStyle);
		GUI.Label (new Rect(70, Screen.height/2, 100, 30),"Please input spaceKey",titleStyle);
	}
}
