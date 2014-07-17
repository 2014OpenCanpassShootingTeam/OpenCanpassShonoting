using UnityEngine;
using System.Collections;

public class Enemy2BoxScript : MonoBehaviour {

	public Transform enemy2;
	public float beforetime = 0.0f;
	public float a ;
	public int b = 7;
	
	// Update is called once per frame
	void Update () {
		
		a = Time.time - beforetime;
		
		if(Time.time > 30 && Time.time < 59){
			
			b = 5;
			
		}else if(Time.time > 60){
			
			b = 3;
			
		}
		
		if(a > b){
			
			Instantiate(enemy2,new Vector3(Random.Range(-9.0f,9.0f),transform.position.y,Random.Range(-3.0f,15.0f)),transform.rotation);
			beforetime = Time.time;
		}
		
	}
}
