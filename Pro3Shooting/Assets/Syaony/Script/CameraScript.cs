using UnityEngine;
using System.Collections;

public class CameraScript : MonoBehaviour {

	public float shakeRange;
	private float shakeTime = 0.0f;

	private Vector3 savePosition;
	private float lowRangeX;
	private float lowRangeZ;
	private float maxRangeX;
	private float maxRangeZ;

	private float x_val;
	private float z_val;

	// Use this for initialization
	void Start () {
	
		savePosition = transform.position;
		lowRangeZ = savePosition.z - shakeRange;
		maxRangeZ = savePosition.z + shakeRange;
		lowRangeX = savePosition.x - shakeRange;
		maxRangeX = savePosition.x + shakeRange;

	}


	// Update is called once per frame
	void Update () {

		shakeTime -= Time.deltaTime;
		if (shakeTime > 0.0f){
			x_val = Random.Range(lowRangeX,maxRangeX);
			z_val = Random.Range(lowRangeZ,maxRangeZ);
			transform.position = new Vector3(x_val,transform.position.y,z_val);
		} else {
			transform.position = savePosition;
			shakeTime = 0.0f;
		}

	}


	public void setShakeTime(float setTime){
		shakeTime = setTime;
	}
}
