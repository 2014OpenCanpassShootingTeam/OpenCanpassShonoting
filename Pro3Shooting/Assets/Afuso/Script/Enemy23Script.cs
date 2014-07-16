using UnityEngine;
using System.Collections;

public class Enemy23Script : MonoBehaviour {
	
	public float z = 0;
	public Transform target;
	public int x = 0;

	void Start(){

		target = GameObject.Find("Player").transform;
	
	}

	// Update is called once per frame
	void Update () {

		z = z + 0.03f;

		if (z > 14.0f) {

			if(x < 50){
				//Debug .Log(x);
				transform.LookAt (target);
				x = x + 1;
			}
			transform.Translate (0,0, 0.03f);
			
				
		}else if(z > 5.0f && z < 14.0f){

			z = z + 0.03f;
			rigidbody.angularVelocity = Vector3.zero;

		}else{

			transform.Translate (0,0,-0.03f);
				
		}
	
	}

	void OnCollisionEnter(Collision collision){
		
		if(collision.gameObject.tag == "Player" || collision.gameObject.tag == "PlayerBullet"){
			
			Destroy(gameObject);
			
		}
		
	}
}
