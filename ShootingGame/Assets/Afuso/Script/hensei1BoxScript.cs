using UnityEngine;
using System.Collections;

public class hensei1BoxScript : MonoBehaviour {

	public float beforeTime = 5.0f;
	public Transform hensei1;
	/*public float baseTime;

	void Start(){

		baseTime = Time.time;
	}*/
	
	// Update is called once per frame
	void Update () {
	
		beforeTime += Time.deltaTime;

		if(beforeTime > 8.0f){

			if(Time.time <= 20){
				
				Instantiate(hensei1,new Vector3(transform.position.x,transform.position.y,15),transform.rotation);
				beforeTime = 0.0f;
				
			}else if(Time.time > 20 && Time.time <= 40){
				
				Instantiate(hensei1,new Vector3(8,transform.position.y,15),transform.rotation);
				Instantiate(hensei1,new Vector3(-8,transform.position.y,15),transform.rotation);
				beforeTime = 0.0f;
				
			}else if(Time.time > 40 ){
				
				Instantiate(hensei1,new Vector3(transform.position.x,transform.position.y,15),transform.rotation);
				transform.rotation = Quaternion.Euler(0,50,0);
				Instantiate(hensei1,new Vector3(15,transform.position.y,10),transform.rotation);
				Instantiate(hensei1,new Vector3(15,transform.position.y,5),transform.rotation);
				transform.rotation = Quaternion.Euler(0,0,0);
				beforeTime = 0.0f;
				
			}
		}


	}
}
