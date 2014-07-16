using UnityEngine;
using System.Collections;

public class ThonderBombScript : MonoBehaviour {

	private float Timer = 0;
	public float disappearStartBomb = 2.0f;
	public float disappearSpeed = 0.1f;
	private Vector3 disappearVector = new Vector3(1,0,1);
	
	// Update is called once per frame
	void Update () {
	
		Timer += Time.deltaTime;
		if (Timer > disappearStartBomb){
			transform.localScale -= disappearSpeed * disappearVector;
			//transform.Translate(0,disappearSpeed/2,0);
		}

		if (transform.localScale.x < disappearSpeed){
			Object.Destroy(gameObject);
		}

	}
}
