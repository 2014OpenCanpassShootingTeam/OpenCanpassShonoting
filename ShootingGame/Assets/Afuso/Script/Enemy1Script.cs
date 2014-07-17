using UnityEngine;
using System.Collections;

public class Enemy1Script : MonoBehaviour {

	// Update is called once per frame
	void Update () {

		transform.Translate (0,0,-0.03f);

		if(transform.position.z < -20.0f || transform.position.x < -20.0f || transform.position.x > 20.0f){
			
			Destroy(gameObject);
			
		}
		
	}

	void OnCollisionEnter(Collision collision){
		
		if(collision.gameObject.tag == "Player" || collision.gameObject.tag == "PlayerBullet"){

			Destroy(gameObject);
			
		}
		
	}
}
