using UnityEngine;
using System.Collections;

public class hensei5BoxScript : MonoBehaviour {

	public float beforeTime = 5.0f;
	public Transform hensei5;
	public float Interval = 6.0f;
	public float Level1Time = 0;
	public float Level2Time = 30;
	public float Level3Time = 60;
	public float Level4Time = 90;
	public float Level5Time = 120;
	
	// Update is called once per frame
	void Update () {
		
		beforeTime += Time.deltaTime;
		
		if(beforeTime > Interval){
			
			if(Time.time > Level1Time && Time.time <= Level2Time){
				
				Instantiate(hensei5,new Vector3(-15,transform.position.y,17),transform.rotation);
				beforeTime = 0.0f;
				//Debug.Log("Level1");
			}else if(Time.time > Level2Time && Time.time <= Level3Time){

				transform.rotation = Quaternion.Euler(0,180,0);
				Instantiate(hensei5,new Vector3(15,transform.position.y,-17),transform.rotation);
				transform.rotation = Quaternion.Euler(0,0,0);
				beforeTime = 0.0f;
				//Debug.Log("Level2");
			}

		}

	}

}