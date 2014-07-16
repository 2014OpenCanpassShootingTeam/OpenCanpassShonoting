using UnityEngine;
using System.Collections;

public class MissilePScript : MonoBehaviour {

	// Update is called once per frame
	void Update () {

		transform.Translate (0,0.05f,0);


	
	}

	void OnCollisionEnter(Collision collision){

		if(collision.gameObject.tag == "Enemy"){

			Destroy(gameObject);

		}


	}
}
