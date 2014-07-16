using UnityEngine;
using System.Collections;

public class EnamyBullet1Script : MonoBehaviour {

	private void OnTriggerEnter(Collider collisionInfo){
		if (collisionInfo.gameObject.tag == "Player"){
			collisionInfo.gameObject.SendMessage("ApplyDamage");
		} else {
			Object.Destroy(gameObject);
		}
	}
}
