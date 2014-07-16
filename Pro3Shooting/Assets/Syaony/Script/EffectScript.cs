using UnityEngine;
using System.Collections;

public class EffectScript : MonoBehaviour {


	private float Timer;
	private float disapearTime;

	// Use this for initialization
	void Start () {
		Timer = 0;
		disapearTime = 2.0f;
	}
	
	// Update is called once per frame
	void Update () {
	
		Timer += Time.deltaTime;
		if (Timer > disapearTime){
			Object.Destroy(gameObject);
		}

	}
}
