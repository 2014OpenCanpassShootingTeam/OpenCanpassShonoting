using UnityEngine;
using System.Collections;

public class hensei2BoxScript : MonoBehaviour {

	public float beforeTime = 5.0f;
	public Transform hensei2;
	/*public float baseTime;

	void Start(){

		baseTime = Time.time;
	}*/
	
	// Update is called once per frame
	void Update () {

		beforeTime += Time.deltaTime;
		
		if(beforeTime > 8.0f){
			
			if(Time.time <= 20){
				
				Instantiate(hensei2,new Vector3(-15,transform.position.y,15),transform.rotation);
				beforeTime = 0.0f;
				
			}else if(Time.time > 20 && Time.time <= 40){
				
				Instantiate(hensei2,new Vector3(-15,transform.position.y,15),transform.rotation);
				Instantiate(hensei2,new Vector3(-20,transform.position.y,10),transform.rotation);
				beforeTime = 0.0f;
				
			}else if(Time.time > 40 ){
				
				Instantiate(hensei2,new Vector3(-15,transform.position.y,15),transform.rotation);
				Instantiate(hensei2,new Vector3(-20,transform.position.y,10),transform.rotation);
				Instantiate(hensei2,new Vector3(-25,transform.position.y,8),transform.rotation);
				beforeTime = 0.0f;
				
			}
		}
		
		
	}
}
