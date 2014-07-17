using UnityEngine;
using System.Collections;

public class Enemy3Script : MonoBehaviour {
	
	public float z = 0;
	public Transform target;
	public int x = 0;
	public float beforeTime = 0.0f;

	void Start(){

		target = GameObject.Find("Player").transform;
	}

	// Update is called once per frame
	void Update () {

		beforeTime += Time.deltaTime;

		if(beforeTime <= 5 ){

			transform.Translate(0,0,-0.03f);
			//Debug.Log("aaaaaaaaaaa");
		}else if(beforeTime > 5 && beforeTime < 7){

			rigidbody.angularVelocity = Vector3.zero;
			transform.LookAt (target);
			//Debug.Log("bbbbbbbbbbb");
		}else{

			transform.Translate (0,0,0.03f);

		}

		if(transform.position.z < -20.0f || transform.position.x < -20.0f || transform.position.x > 20.0f){
			
			Destroy(gameObject);
			
		}
	
	}

	void OnCollisionEnter(Collision collision){
		
		if(collision.gameObject.tag == "Player" || collision.gameObject.tag == "PlayerBullet"){

			//beforeTime = 0.0f;
			Destroy(gameObject);
			
		}
		
	}
}
