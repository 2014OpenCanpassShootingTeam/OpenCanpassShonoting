using UnityEngine;
using System.Collections;

public class FireBombScript : MonoBehaviour {

	private float Timer;
	public float explodeTime = 1.5f;
	public float disExlplodeTime = 3.0f;
	public Vector3 direction;
	public float bombVelocity = 1.0f;
	public float explodeR;
	public GameObject fireBombExplodePrefab;

	// Use this for initialization
	void Start () {
		Timer = 0.0f;
	}
	
	// Update is called once per frame
	void Update () {
	
		Timer += Time.deltaTime;
		if (Timer < explodeTime ){
			transform.Translate(0,0,- bombVelocity);
		} else {
			Instantiate(fireBombExplodePrefab, transform.position, transform.rotation);
			Object.Destroy(gameObject);
		}


	}
}
