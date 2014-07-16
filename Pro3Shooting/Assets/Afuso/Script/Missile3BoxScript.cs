using UnityEngine;
using System.Collections;

public class Missile3BoxScript : MonoBehaviour {

	public Transform  missile3;
	public int c=0;

	// Update is called once per frame
	void Update () {

		if(Time.frameCount % 100 == 0){

			int i;

			for(i = 1;i < 6;i++){
				transform.Rotate(0,0,10);
				Instantiate (missile3,transform.position,transform.rotation);
				//Debug.Log(transform.rotation);
			}

			c = c+1;

			if( c <= 2){
				transform.localRotation = Quaternion.Euler(90,30,0);
				
				
			}else if( c > 2 ){
				
				transform.localRotation = Quaternion.Euler(90,210,0);
				//Debug.Log("aaaaaaaaaaaaa");
			}

			i = 1;

		}
	}
}
