using UnityEngine;
using System.Collections;

public class MissileBoxScript : MonoBehaviour {

	public Transform missile;
	public float beforeTime = 0.0f;
	public int Bullet = 3;
	public int EmptyBullet = 0;
	public float Interval = 0.3f;
	public int Interval2 = 120;
	public float Level1Time = 0;
	public float Level2Time = 90;
	public float Level3Time = 120;

	// Update is called once per frame
	void Update () {

		if(Time.time > Level2Time && Time.time <= Level3Time){
			
			Bullet = 6;
			Interval2 = 100;
			//Debug.Log("second");
		}else if(Time.time > Level3Time ){
			Bullet = 9;
			Interval2  = 80;
			//Debug.Log("third");
		}

		beforeTime += Time.deltaTime;

		if(beforeTime > Interval){

			EmptyBullet = EmptyBullet + 1 ;

			if(EmptyBullet <= Bullet){

				Instantiate( missile,new Vector3(transform.position.x,transform.position.y,transform.position.z  -1),transform.rotation);
				beforeTime = 0.0f;

			}else{

				if(EmptyBullet == Interval2)EmptyBullet = 0;

			}
		
		}
		
	}
}
