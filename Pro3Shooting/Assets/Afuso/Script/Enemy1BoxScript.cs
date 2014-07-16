using UnityEngine;
using System.Collections;

public class Enemy1BoxScript : MonoBehaviour {

	public Transform enemy1;
	
	void Update () {

		if(Time.frameCount %  1000 == 0){


			Instantiate(enemy1,new Vector3(Random.Range(-9.0f,9.0f),transform.position.y,Random.Range(-3.0f,15.0f)),transform.rotation);

		}
	
		if(transform.position.z < -15.0f){
			
			Destroy(gameObject);
			
		}

	}
}
