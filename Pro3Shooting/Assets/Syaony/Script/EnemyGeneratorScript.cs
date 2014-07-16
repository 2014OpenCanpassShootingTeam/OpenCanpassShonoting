using UnityEngine;
using System.Collections;

public class EnemyGeneratorScript : MonoBehaviour {

	private float interval = 1.0f;
	private float intervalAdd = 0.1f;
	private float intervalAddTime = 10.0f;

	private int enemyType;

	//Enemy Prefab
	public GameObject enemyPrefab1;
	public GameObject enemyPrefab2;
	
	private float timer;
	private float intervalTimer;
	
	private float offsetX;
	private float offsetZ;
	private Vector3 createPosition;
	
	// Use this for initialization
	void Start () {
		timer = 0.0f;
		intervalTimer = 0.0f;
	}
	
	// Update is called once per frame
	void Update () {

		enemyType = Random.Range (0,1);
		
		timer -= Time.deltaTime;
		if (timer < 0.0){

			//enemy Type
			enemyType = Random.Range (0,2);
			Debug.Log(enemyType);

			offsetX = Random.Range(-40.0f, 60.0f);
			offsetZ = Random.Range(40, 50);
			
			createPosition = new Vector3(offsetX, 0, offsetZ);


			//Create enemy switch
			switch(enemyType){
				case 0:
					Instantiate(enemyPrefab1, createPosition, transform.rotation);
					break;
				case 1:
					Instantiate(enemyPrefab2, createPosition, transform.rotation);
					break;
				default:
					break;
			}


			timer = interval;

		}

		/* create enemy interval add */
		intervalTimer += Time.deltaTime;
		if (intervalTimer > intervalAddTime && interval > 0){
			intervalTimer = 0.0f;
			interval -= intervalAdd;
		}
	}

}
