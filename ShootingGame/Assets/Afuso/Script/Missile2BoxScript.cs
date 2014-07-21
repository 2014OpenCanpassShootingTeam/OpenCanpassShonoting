using UnityEngine;
using System.Collections;

public class Missile2BoxScript : MonoBehaviour {

	public Transform missile2;
	public Transform target;
	//public int a = 40;
	public float beforeTime = 0.0f;
	public float Interval = 0.6f;
	public float Level1Time = 0;
	public float Level2Time = 90;
	public float Level3Time = 120;
	//public float x = 15.0f;

	void Start(){

		target = GameObject.Find("Player").transform;
	}

	// Update is called once per frame
	void Update () {

		//transform.rotation = Quaternion.Euler(0,0,Random.Range(0,360));

		beforeTime += Time.deltaTime;

		transform.LookAt(target);

		transform.Rotate (0,Random.Range(-40,40),0);

		//Debug.Log (Time.time);

		if(Time.time > Level2Time && Time.time <= Level3Time){

			//a = 30;
			Interval = 0.4f;
			//Debug.Log("second");
		}else if(Time.time > Level3Time ){
			//a = 20;
			Interval = 0.3f;
			//Debug.Log("third");
		}

		if(beforeTime > Interval){

			Instantiate(missile2,transform.position,transform.rotation);
			beforeTime = 0.0f;

		}



	}
}
