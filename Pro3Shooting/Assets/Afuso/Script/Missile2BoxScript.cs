using UnityEngine;
using System.Collections;

public class Missile2BoxScript : MonoBehaviour {

	public Transform missile2;
	//public float x = 15.0f;

	// Update is called once per frame
	void Update () {

		transform.Rotate(0,0,10);

		if(Time.frameCount % 15 == 0){

			//transform.Rotate(0,0,30);
			Instantiate (missile2,transform.position,transform.rotation);
		}

	}
}
