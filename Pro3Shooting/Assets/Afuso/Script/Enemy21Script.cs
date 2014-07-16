using UnityEngine;
using System.Collections;

public class Enemy21Script : MonoBehaviour {

	// Update is called once per frame
	void Update () {

		transform.Translate (0,0,-0.03f);

		if(transform.position.z < -15.0f){
			
			Destroy(gameObject);
			
		}
		
	}

	void OnCollisionEnter(Collision collision){
		
		if(collision.gameObject.tag == "Player" || collision.gameObject.tag == "PlayerBullet"){

			Destroy(gameObject);
			
		}
		
	}
}
