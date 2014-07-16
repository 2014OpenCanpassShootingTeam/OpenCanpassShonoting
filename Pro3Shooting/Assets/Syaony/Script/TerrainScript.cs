using UnityEngine;
using System.Collections;

public class TerrainScript : MonoBehaviour {


	private float speed = -1;

	// Use this for initialization
	void Start () {
		//transform.rigidbody.AddForce(new Vector3(0,0,1));
	}


	void Update(){
		transform.Translate(0,0,speed);

		if (transform.position.z < -2000){
			transform.position = new Vector3(-1000,-10,0);
		}
	}

}
