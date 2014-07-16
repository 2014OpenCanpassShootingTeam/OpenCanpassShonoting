using UnityEngine;
using System.Collections;

public class BulletScript : MonoBehaviour {

	private void OnTriggerEnter(Collider other){
		Object.Destroy(gameObject);
	}
}
