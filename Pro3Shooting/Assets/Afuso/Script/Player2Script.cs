using UnityEngine;
using System.Collections;

public class Player2Script : MonoBehaviour {

	public float x = 0;

	// Update is called once per frame
	void Update () {

		if(transform.position.x > 10.5f){
			
			transform.position =  new Vector3(9.5f,transform.position.y,transform.position.z);
			
		}else if(transform.position.x < -10.5f){
			
			transform.position =  new Vector3(-9.5f,transform.position.y,transform.position.z);
		}
		
		x = Input.GetAxis ("Horizontal");
		
		transform.Translate (x *0.5f,0,0);
	
	}


}
