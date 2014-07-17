using UnityEngine;
using System.Collections;

public class MissilePBoxScript : MonoBehaviour {

	public Transform missilep;

	// Update is called once per frame
	void Update () {
	
		if (Input.GetButtonUp ("Jump")) {
			
			Instantiate( missilep,transform.position,transform.rotation);
			
		}

	}
}
