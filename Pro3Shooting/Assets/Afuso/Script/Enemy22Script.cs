using UnityEngine;
using System.Collections;

public class Enemy22Script : MonoBehaviour {


	public float x = 1.0f;
	public float xx = 0.0f;
	// Update is called once per frame
	void Update () {

		transform.Translate (xx,0,-0.04f);
		xx = 0.000001f*(x  *  x);
		x = x + 1.0f;

		if(transform.position.x > 10.0f || -10.0f > transform.position.x || transform.position.z < -15.0f){

			Destroy(gameObject);

		}
	
	}

	void OnCollisionEnter(Collision collision){
		
		if(collision.gameObject.tag == "Player" || collision.gameObject.tag == "PlayerBullet"){
			
			Destroy(gameObject);
			
		}
		
	}
}
