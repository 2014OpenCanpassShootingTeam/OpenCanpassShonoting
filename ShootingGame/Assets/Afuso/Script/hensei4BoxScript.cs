using UnityEngine;
using System.Collections;

public class hensei4BoxScript : MonoBehaviour {
	
	public float beforeTime = 5.0f;
	public Transform hensei4;
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
				
				Instantiate(hensei4,new Vector3(5,transform.position.y,15),transform.rotation);
				beforeTime = 0.0f;
				//Debug.Log("Level1");
			}else if(Time.time > Level2Time && Time.time <= Level3Time){
		
				Instantiate(hensei4,new Vector3(0,transform.position.y,15),transform.rotation);
				Instantiate(hensei4,new Vector3(-4,transform.position.y,15),transform.rotation);
				beforeTime = 0.0f;
				//Debug.Log("Level2");
			}

		}

	}

}
