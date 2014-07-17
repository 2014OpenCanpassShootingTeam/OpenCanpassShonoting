using UnityEngine;
using System.Collections;

public class MissileBoxScript : MonoBehaviour {

	public Transform missile;
	public float beforeTime = 0.0f;
	public int x = 0;
	public int a = 3;

	// Update is called once per frame
	void Update () {

		if(Time.time > 30 && Time.time < 59){
			
			a = 6;
			//Debug.Log("second");
		}else if(Time.time > 60 ){
			a = 9;
			//Debug.Log("third");
		}

		beforeTime += Time.deltaTime;

		if(beforeTime > 0.3f){

			x = x + 1 ;

			if(x <= a){

				Instantiate( missile,new Vector3(transform.position.x,transform.position.y,transform.position.z  -1),transform.rotation);
				beforeTime = 0.0f;
			}else{

				if(x == 80)x = 0;

			}
		
		}
		
	}
}
