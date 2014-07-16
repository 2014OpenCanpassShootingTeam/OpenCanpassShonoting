using UnityEngine;
using System.Collections;

public class FireBombExplodeScript : MonoBehaviour {

	private float Timer;
	public float disExlplodeTime = 1.5f;

	public AudioClip fireBombExplodeSE;


	void Start(){
		audio.PlayOneShot(fireBombExplodeSE);
		GameObject.Find ("Main Camera").SendMessage("setShakeTime",2.0f);
	}

	// Update is called once per frame
	void Update () {
	
		Timer += Time.deltaTime;
		if (Timer > disExlplodeTime ){
			Object.Destroy(gameObject);
		}

	}
}
