using UnityEngine;
using System.Collections;

public class MissileScript : MonoBehaviour {
	// Update is called once per frame
	void Update () {

		transform.Translate (0,-0.05f,0);

		if(transform.position.z < -15.0f){
			
			Destroy(gameObject);
			
		}
		
	}

	void OnCollisionEnter(Collision collision){
		
		if(collision.gameObject.tag == "Player"){
			
			Destroy(gameObject);
			
		}
		
	}
}
