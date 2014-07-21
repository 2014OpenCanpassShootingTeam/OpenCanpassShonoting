using UnityEngine;
using System.Collections;

public class Missile3BoxScript : MonoBehaviour {
	
	public Transform  missile3;
	public float beforeTime = 0.0f;
	public float Level1Time = 0;
	public float Level2Time = 90;
	public float Level3Time = 120;
	public int frontangle1 = 20;
	public int frontangle2 = 200;
	public int Bullet = 3;
	
	// Update is called once per frame
	void Update () {
		
		//a = Time.time - beforeTime;
		beforeTime += Time.deltaTime;
		
		if(beforeTime % 1.5 > 0 && beforeTime % 1.5 < 0.05){ //わからんがこうなった
			
			int i;
			//Debug.Log(Time.time);
			if(Time.time > Level2Time && Time.time <= Level3Time){
				
				Bullet = 5;
				frontangle1 = 30;
				frontangle2 = 210;
				//Debug.Log("second");
			}else if(Time.time > Level3Time ){
				Bullet = 7;
				frontangle1 = 40;
				frontangle2 = 220;
				//Debug.Log("third");
			}
			
			if( beforeTime <= 4.7){
				transform.localRotation = Quaternion.Euler(90,frontangle1,0);
				
				
			}else if( beforeTime > 4.7 ){
				
				transform.localRotation = Quaternion.Euler(90,frontangle2,0);
			}
			
			
			for(i = 1;i <= Bullet;i++){
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
