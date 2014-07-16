using UnityEngine;
using System.Collections;

public class ThonderBulletScript : BulletScript{//MonoBehaviour {

	public float addPower = 200.0f;
	public float chaceTime = 0.5f;
	private float Timer = 0.0f;
	private GameObject target;
	public float firstSpeed = -1.0f;
	public float chaceSpeed = 3.0f;
	private float speed = 3.0f;
	private bool isChace = false;

	// Use this for initialization
	void Start () {
		speed = firstSpeed;
	}
	
	// Update is called once per frame
	void Update () {
	
		transform.position += transform.forward * speed;

		if (!isChace){
			Timer += Time.deltaTime;
			if (Timer > chaceTime && GameObject.FindGameObjectWithTag("Enemy") != null){
				isChace = true;
				target = GameObject.FindGameObjectWithTag("Enemy");
	
				transform.LookAt(target.transform.position);

				speed = chaceSpeed;
			}
		}
	}

}