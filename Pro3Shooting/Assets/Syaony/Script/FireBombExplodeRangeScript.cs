using UnityEngine;
using System.Collections;

public class FireBombExplodeRangeScript : MonoBehaviour {

	private float Timer;
	public float disExlplodeTime = 0.5f;
	
	// Update is called once per frame
	void Update () {
		
		Timer += Time.deltaTime;
		if (Timer > disExlplodeTime ){
			Object.Destroy(gameObject);
		}
		
	}
}
