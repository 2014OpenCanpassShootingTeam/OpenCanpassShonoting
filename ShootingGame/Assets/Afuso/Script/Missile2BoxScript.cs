using UnityEngine;
using System.Collections;

public class Missile2BoxScript : MonoBehaviour {

	public Transform missile2;
	public Transform target;
	public int a = 40;
	//public float x = 15.0f;

	void Start(){

		target = GameObject.Find("Player").transform;
	}

	// Update is called once per frame
	void Update () {

		//transform.rotation = Quaternion.Euler(0,0,Random.Range(0,360));

		transform.LookAt(target);

		transform.Rotate (0,Random.Range(-40,40),0);

		//Debug.Log (Time.time);

		if(Time.time > 30 && Time.time < 59){

			a = 30;
			//Debug.Log("second");
		}else if(Time.time > 60 ){
			a = 20;
			//Debug.Log("third");
		}

		if(Time.frameCount % a == 0){

			//transform.rotation = Quaternion.Euler(90,0,0);
			//transform.Rotate(0,0,Random.Range(-40,40));
			Instantiate(missile2,transform.position,transform.rotation);

		}

	}
}
