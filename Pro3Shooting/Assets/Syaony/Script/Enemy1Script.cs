using UnityEngine;
using System.Collections;

public class Enemy1Script : MonoBehaviour {

	/* Enemy Status */
	public int HP = 1;
	public int experience = 1;

	//Enemy bullet
	public GameObject enemyBulletPrefab;
	private float bulletTime = 0.0f;
	public float bulletInterval = 1.0f;
	private Vector3 bulletVelocity;
	public float bulletSpeed;

	//explode
	public GameObject explodePrefab;


	// Use this for initialization
	void Start () {
		/* move */
		Vector3 velocity = transform.position;
		float randomSpeed = Random.Range (-600.0f, -1000.0f);
		velocity = new Vector3(0.0f, 0.0f, randomSpeed);
		transform.rigidbody.AddForce(velocity);
	}
	
	// Update is called once per frame
	void Update () {
	
		/* Enemy bullet */
		if (bulletTime > bulletInterval){
			bulletTime = 0.0f;

			//bullet1
			GameObject enemyBullet = (GameObject)Instantiate(enemyBulletPrefab, transform.position, transform.rotation);
			bulletVelocity = enemyBullet.transform.position;
			bulletVelocity = new Vector3(0, 0, -bulletSpeed);
			enemyBullet.transform.rigidbody.AddForce(bulletVelocity, ForceMode.VelocityChange);

		}
		
		bulletTime += Time.deltaTime;

	}


	private void OnTriggerEnter(Collider collisionInfo){
		if (collisionInfo.gameObject.tag == "Player"){
			//player damage
			collisionInfo.gameObject.SendMessage("ApplyDamage");
			
		} else if (collisionInfo.gameObject.tag == "FireBullet"){
			HP--;
			if (HP < 0){
				GameObject gameController = GameObject.Find("GameController");
				gameController.SendMessage("GetScore",10);
				gameController.SendMessage("getFireExperience",experience);
				Instantiate(explodePrefab, transform.position, transform.rotation);
				Object.Destroy(gameObject);
			}
		} else if (collisionInfo.gameObject.tag == "FreezeBullet"){
			HP--;
			if (HP < 0){
				GameObject gameController = GameObject.Find("GameController");
				gameController.SendMessage("GetScore",10);
				gameController.SendMessage("getFreezeExperience",experience);
				Instantiate(explodePrefab, transform.position, transform.rotation);
				Object.Destroy(gameObject);
			}
		} else if (collisionInfo.gameObject.tag == "ThonderBullet"){
			HP--;
			if (HP < 0){
				GameObject gameController = GameObject.Find("GameController");
				gameController.SendMessage("GetScore",10);
				gameController.SendMessage("getThonderExperience",experience);
				Instantiate(explodePrefab, transform.position, transform.rotation);
				Object.Destroy(gameObject);
			}
		} else if (collisionInfo.gameObject.tag == "PlayerBomb") {
			GameObject gameController = GameObject.Find("GameController");
			gameController.SendMessage("GetScore",10);
			Instantiate(explodePrefab, transform.position, transform.rotation);
			Object.Destroy(gameObject);
		} else {
			Object.Destroy(gameObject);
		}
	}
}
