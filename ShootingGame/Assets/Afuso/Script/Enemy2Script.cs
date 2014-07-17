using UnityEngine;
using System.Collections;

public class Enemy2Script : MonoBehaviour {


	public float x = 1.0f;
	public float xx = 0.0f;
	// Update is called once per frame
	void Update () {

		transform.Translate (xx,0,-0.04f);
		xx = 0.000001f*(x  *  x);
		x = x + 1.0f;

		if(transform.position.z < -20.0f || transform.position.x < -30.0f || transform.position.x > 20.0f){
			
			Destroy(gameObject);
			
		}
	
	}

	void OnCollisionEnter(Collision collision){
		
		if(collision.gameObject.tag == "Player" || collision.gameObject.tag == "PlayerBullet"){
			
			Destroy(gameObject);
			
		}
		
	}
}
