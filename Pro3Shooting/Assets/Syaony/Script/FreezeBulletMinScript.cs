using UnityEngine;
using System.Collections;

public class FreezeBulletMinScript : MonoBehaviour {


	private float Timer;
	public float disappearTime = 0.01f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		Timer += Time.deltaTime;
		if (Timer > disappearTime){
			Object.Destroy(gameObject);
		}
	}
}
