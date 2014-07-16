using UnityEngine;
using System.Collections;

public class Enemy2BoxScript : MonoBehaviour {

	public Transform enemy2;

	// Update is called once per frame
	void Update () {

		if(Time.frameCount % 1000 == 0){

			Instantiate(enemy2,new Vector3(Random.Range(-9.0f,9.0f),transform.position.y,Random.Range(-3.0f,15.0f)),  transform.rotation);

		}

		if(transform.position.x > 10.0f || -10.0f > transform.position.x || transform.position.z < -15.0f){
			
			Destroy(gameObject);
			
		}
	
	}
}
