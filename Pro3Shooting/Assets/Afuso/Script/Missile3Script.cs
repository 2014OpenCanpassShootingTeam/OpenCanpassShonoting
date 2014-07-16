using UnityEngine;
using System.Collections;

public class Missile3Script : MonoBehaviour {
	
	// Update is called once per frame
	void Update () {

		 transform.Translate(0,-0.05f,0);

		if(transform.position.x > 10.0f || -10.0f > transform.position.x || transform.position.z < -15.0f  || transform.position.z > 15.0f){
			
			Destroy(gameObject);
			
		}
	
	}

	void OnCollisionEnter(Collision collision){
		
		if(collision.gameObject.tag == "Player"){
			
			Destroy(gameObject);
			
		}
		
	}
}
