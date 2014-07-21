using UnityEngine;
using System.Collections;

public class hensei3BoxScript : MonoBehaviour {

	public float beforeTime = 5.0f;
	public Transform hensei3;
	public float Interval = 10.0f;
	public float Level1Time = 0;
	public float Level2Time = 30;
	public float Level3Time = 60;
	public float Level4Time = 90;
	public float Level5Time = 120;
	/*public float baseTime;

	void Start(){

		baseTime = Time.time;
	}*/
	
	// Update is called once per frame
	void Update () {
		
		beforeTime += Time.deltaTime;
		
		if(beforeTime > Interval){
			
			if(Time.time > Level3Time && Time.time <= Level4Time){

				Instantiate(hensei3,new Vector3(transform.position.x,transform.position.y,15),transform.rotation);
				beforeTime = 0.0f;
				//Debug.Log("Level3");
			}else if(Time.time > Level4Time && Time.time <= Level5Time){
				Interval = 14.0f;
				transform.rotation = Quaternion.Euler(0,310,0);
				Instantiate(hensei3,new Vector3(-15,transform.position.y,15),transform.rotation);
				transform.rotation = Quaternion.Euler(0,0,0);
				Instantiate(hensei3,new Vector3(transform.position.x,transform.position.y,15),transform.rotation);
				beforeTime = 0.0f;
				//Debug.Log("Level4");
			}else if(Time.time > Level5Time ){
				Interval = 16.0f;
				Instantiate(hensei3,new Vector3(8,transform.position.y,15),transform.rotation);
				Instantiate(hensei3,new Vector3(-8,transform.position.y,15),transform.rotation);
				beforeTime = 0.0f;
				//Debug.Log("Level5");
			}
		}
		
		
	}
}
