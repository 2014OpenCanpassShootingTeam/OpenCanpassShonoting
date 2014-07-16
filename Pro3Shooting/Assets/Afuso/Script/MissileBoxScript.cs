using UnityEngine;
using System.Collections;

public class MissileBoxScript : MonoBehaviour {

	public Transform missile;
	public int x = 0;

	// Update is called once per frame
	void Update () {
	
		if(Time.frameCount % 25 == 0){

			x = x + 1 ;

			if(x < 6){

				Instantiate( missile,new Vector3(transform.position.x,transform.position.y,transform.position.z  -1),transform.rotation);

			}else{

				if(x == 12)x = 0;

			}
		
		}
		
	}
}
