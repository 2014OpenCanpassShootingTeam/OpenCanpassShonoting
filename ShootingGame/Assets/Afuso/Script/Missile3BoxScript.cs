using UnityEngine;
using System.Collections;

public class Missile3BoxScript : MonoBehaviour {

	public Transform  missile3;
	public float beforeTime = 0.0f;
	//public float a;
	public int b = 3;
	public int c = 0;
	public int d = 20;
	public int e = 200;

	// Update is called once per frame
	void Update () {

		//a = Time.time - beforeTime;
		beforeTime += Time.deltaTime;

		if(beforeTime % 1.5 > 0 && beforeTime % 1.5 < 0.05){

			int i;
			
			if(Time.time > 30 && Time.time < 59){
				
				b = 5;
				d = 30;
				e = 210;
				//Debug.Log("second");
			}else if(Time.time > 60 ){
				b = 7;
				d = 40;
				e = 220;
				//Debug.Log("third");
			}

			if( beforeTime <= 4.7){
				transform.localRotation = Quaternion.Euler(90,d,0);
				
				
			}else if( beforeTime > 4.7 ){
				
				transform.localRotation = Quaternion.Euler(90,e,0);
			}

			//c = c+1;

			for(i = 1;i <= b;i++){
				//Debug.Log(b);
				transform.Rotate(0,0,10);
				Instantiate (missile3,transform.position,transform.rotation);
				//beforeTime = Time.time;
				//Debug.Log(transform.rotation);
			}

			i = 1;


		}
	}
}
