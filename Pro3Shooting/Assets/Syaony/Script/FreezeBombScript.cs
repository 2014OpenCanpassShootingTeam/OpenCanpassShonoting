using UnityEngine;
using System.Collections;

public class FreezeBombScript : MonoBehaviour {


	private Vector3 target;
	public float speed = 0.2f;
	public GameObject freezeBreakBlockParticlePrefab;

	// Use this for initialization
	void Start () {
		target = GameObject.Find ("Player").transform.position;
	}
	
	// Update is called once per frame
	void Update () {
	
		target = GameObject.Find ("Player").transform.position;
		transform.LookAt(target);
		transform.Translate(new Vector3(speed,0,0));

	}


	private void OnTriggerEnter(Collider collisionInfo){
		GameObject.Destroy(gameObject);
		Instantiate(freezeBreakBlockParticlePrefab, transform.position, transform.rotation);
	}


}
