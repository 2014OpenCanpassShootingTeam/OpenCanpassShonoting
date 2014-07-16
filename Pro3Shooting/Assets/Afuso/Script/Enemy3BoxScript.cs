using UnityEngine;
using System.Collections;

public class Enemy3BoxScript : MonoBehaviour {

	public Transform enemy3;

	// Update is called once per frame
	void Update () {

		if(Time.frameCount % 400 == 0){

			Instantiate(enemy3,new Vector3(Random.Range(-9.0f,9.0f),transform.position.y,Random.Range(-3.0f,15.0f)),transform.rotation);

		}
	
	}
}
