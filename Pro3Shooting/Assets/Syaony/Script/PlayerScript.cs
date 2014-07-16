using UnityEngine;
using System.Collections;

public class PlayerScript : MonoBehaviour {

	//speed
	public float movingSpeed = 50.0f;
	//private CharacterController controller;
	private Vector3 velocity;


	//Player image
	public Material[] playerMaterial = new Material[3];
	private int playerMode = 0;


	//animation
	private float animationInterval = 0.1f;
	private float animationTimer = 0.0f;
	private bool animationFlag = true;


	/* Bullet */
	private float bulletTime = 0.0f;
	private Vector3 direction;
	private Vector3 bulletVelocity;

	//Basic Bullet
	public GameObject basicBulletPrefab;
	public float basicBulletInterval = 0.2f;
	private float basicBulletTime = 0.0f;
	private bool basicBulletEnable = true;

	//Fire Bullet
	private int fireLevel = 0;
	public GameObject bulletPrefab;
	public float bulletInterval = 0.2f;
	private bool bulletEnable = true;
	public float fireBulletVelocity = 200.0f;
	
	//Freeze Bullet
	private int freezeLevel = 0;
	public GameObject FreezeBulletPrefab;
	public float freezeBulletInterval = 0.1f;
	private bool freezebulletEnable = true;
	public float freezebulletVelocity = 300.0f;

	//Thonder Bullet
	private int thonderLevel = 0;
	public GameObject ThonderBulletPrefab;
	public float thonderBulletInterval = 0.5f;
	private bool thonderBulletEnable = true;
	public float thonderBulletVelocity = 10.0f;
	private GameObject target;
	private Vector3 chaceThonder;


	/* Bomb */
	public int bomb = 3;

	//Fire Bomb
	public GameObject fireBombPrefab;
	private int BombCounter;
	public float bombInterval = 5.0f;
	private bool bombEnable = true;
	private float bombTime = 0.0f;

	//Freeze Bomb
	public GameObject freezeBombPrefab;
	public int freezeBombDistance = 10;

	//Thonder Bomb
	public GameObject thonderBombPrefab;


	//Explode effect
	public GameObject explodePrefab;

	//Shot SE
	public AudioClip shotSE;
	public AudioClip freezeBulletSE;
	public AudioClip thonderBulletSE;


	/* System object */ 
	private GameObject gameController;
	private GameObject mainCamera;



	// Use this for initialization
	void Start () {
		// 弾の発射方向を指定, z軸を真っ直ぐ飛ぶようにした.
		direction = new Vector3(0, 0, 1);
		//renderer.material = playerMaterial[playerMode];

		/* System object init */
		gameController = GameObject.Find ("GameController");
		mainCamera = GameObject.Find ("Main Camera");

		gameController.SendMessage("bombInfo",bomb);

	}




	// Update is called once per frame
	void Update () {
	
		/* velocity */
		velocity =  new Vector3(-Input.GetAxis("Horizontal"), 0, -Input.GetAxis("Vertical")); 
		velocity *= movingSpeed;
		transform.Translate(velocity * Time.deltaTime);


		/* animation */
		/*animationTimer -= Time.deltaTime;
		if (animationTimer < 0.0f) {
			animationTimer = animationInterval;
			renderer.material.mainTextureOffset = animationFlag ? new Vector3(0.51f, 0.0f, 0.0f) :  new Vector3(0.0f, 0.0f, 0.0f);
			animationFlag = !animationFlag;
		}*/



		/* Player mode change */
		//Fire mode
		if (Input.GetAxis("FireMode") == 1){
			//renderer.material = playerMaterial[0];
			playerMode = 0;
		}

		//Freeze mode
		if (Input.GetAxis("FreezeMode") == 1){
			//renderer.material = playerMaterial[1];
			playerMode = 1;
		}

		//Thonder mode
		if (Input.GetAxis("ThonderMode") == 1){
			//renderer.material = playerMaterial[2];
			playerMode = 2;
		}



		/* Bullet */

		switch(playerMode){

			case 0: //Fire Mode

				if (Input.GetAxis("Fire1") == 1 && bulletEnable) {

					bulletEnable = false;

					GameObject bullet = (GameObject)Instantiate(bulletPrefab, transform.position, transform.rotation);
					bulletVelocity = new Vector3(0, 0, fireBulletVelocity);
					bullet.transform.rigidbody.AddForce(bulletVelocity, ForceMode.VelocityChange);
				
				GameObject bullet2 = (GameObject)Instantiate(bulletPrefab, transform.position, transform.rotation);
					bulletVelocity = new Vector3(40, 0, fireBulletVelocity - 40);
					bullet2.transform.rigidbody.AddForce(bulletVelocity, ForceMode.VelocityChange);
				
					GameObject bullet3 = (GameObject)Instantiate(bulletPrefab, transform.position, transform.rotation);
					bulletVelocity = new Vector3(-40, 0, fireBulletVelocity - 40);
					bullet3.transform.rigidbody.AddForce(bulletVelocity, ForceMode.VelocityChange);

					//Fire Level 1
					if (fireLevel > 0){
						GameObject bullet4 = (GameObject)Instantiate(bulletPrefab, transform.position, transform.rotation);
						bulletVelocity = new Vector3(80, 0, fireBulletVelocity - 80);
						bullet4.transform.rigidbody.AddForce(bulletVelocity, ForceMode.VelocityChange);

						GameObject bullet5 = (GameObject)Instantiate(bulletPrefab, transform.position, transform.rotation);
						bulletVelocity = new Vector3(-80, 0, fireBulletVelocity - 80);
						bullet5.transform.rigidbody.AddForce(bulletVelocity, ForceMode.VelocityChange);

						//Fire Level2
						if (fireLevel > 1){
							GameObject bullet6 = (GameObject)Instantiate(bulletPrefab, transform.position, transform.rotation);
							bulletVelocity = new Vector3(-20, 0, fireBulletVelocity - 20);
							bullet6.transform.rigidbody.AddForce(bulletVelocity, ForceMode.VelocityChange);

							GameObject bullet7 = (GameObject)Instantiate(bulletPrefab, transform.position, transform.rotation);
							bulletVelocity = new Vector3(20, 0, fireBulletVelocity - 20);
							bullet7.transform.rigidbody.AddForce(bulletVelocity, ForceMode.VelocityChange);
						}

					}
					//Shot SE
					audio.PlayOneShot(shotSE);
				}

				bulletTime += Time.deltaTime;
				if (bulletTime > bulletInterval) {
					bulletTime = 0.0f;
					bulletEnable = true;
				}


				//Fire Bomb
				if (Input. GetAxis("Fire2") == 1 && bombEnable && bomb > 0){
					bombEnable = false;
					Instantiate(fireBombPrefab, transform.position, transform.rotation);
					//bomb.transform.rigidbody.AddForce(direction * bombVelocity, ForceMode.VelocityChange);
					bomb--;
					gameController.SendMessage("bombInfo",bomb);
				}
			
				bombTime += Time.deltaTime;
				if (bombTime > bombInterval){
					bombTime = 0.0f;
					bombEnable = true;
				}

				break;


			case 1:	//Freeze Mode

				//Freeze Level1
				if (Input.GetAxis("Fire1") == 1 && freezebulletEnable){

					freezebulletEnable = false;

					GameObject freezeBullet1 = (GameObject)Instantiate (FreezeBulletPrefab, transform.position, transform.rotation);
					freezeBullet1.transform.Translate(0,0, -freezeBullet1.transform.localScale.y);
					freezeBullet1.transform.Rotate (90,0,0);
					freezeBullet1.transform.parent = gameObject.transform;
					freezeBullet1.transform.rigidbody.AddForce(direction * freezebulletVelocity, ForceMode.VelocityChange);

					if (freezeLevel > 0){

						GameObject freezeBullet2 = (GameObject)Instantiate (FreezeBulletPrefab, transform.position, transform.rotation);
						freezeBullet2.transform.Translate(5,0, -freezeBullet2.transform.localScale.y+2);
						freezeBullet2.transform.Rotate (90,0,0);
						freezeBullet2.transform.parent = gameObject.transform;
						freezeBullet2.transform.rigidbody.AddForce(direction * freezebulletVelocity, ForceMode.VelocityChange);

						//Freeze Level2
						if (freezeLevel > 1){
							GameObject freezeBullet3 = (GameObject)Instantiate (FreezeBulletPrefab, transform.position, transform.rotation);
							freezeBullet3.transform.Translate(-5,0, -freezeBullet3.transform.localScale.y+2);
							freezeBullet3.transform.Rotate (90,0,0);
							freezeBullet3.transform.parent = gameObject.transform;
							freezeBullet3.transform.rigidbody.AddForce(direction * freezebulletVelocity, ForceMode.VelocityChange);


							//Freeze Level3
							if (freezeLevel > 2){
								GameObject freezeBullet4 = (GameObject)Instantiate (FreezeBulletPrefab, transform.position, transform.rotation);
								freezeBullet4.transform.Translate(-10,0, -freezeBullet3.transform.localScale.y+5);
								freezeBullet4.transform.Rotate (90,0,0);
								freezeBullet4.transform.parent = gameObject.transform;
								freezeBullet4.transform.rigidbody.AddForce(direction * freezebulletVelocity, ForceMode.VelocityChange);

							}
						}
					}
					//SE
					audio.PlayOneShot(freezeBulletSE);
				}

				bulletTime += Time.deltaTime;
				if (bulletTime > freezeBulletInterval){
					freezebulletEnable = true;
					bulletTime = 0.0f;
				}


				//Freeze Bomb
				if (Input. GetAxis("Fire2") == 1 && bombEnable && bomb > 0){
					bombEnable = false;
					GameObject freezeBomb1 = (GameObject)Instantiate(freezeBombPrefab, new Vector3(transform.position.x,transform.position.y, transform.position.z + freezeBombDistance), transform.rotation);
					freezeBomb1.transform.parent = gameObject.transform;
					GameObject freezeBomb2 = (GameObject)Instantiate(freezeBombPrefab, new Vector3(transform.position.x,transform.position.y, transform.position.z - freezeBombDistance), transform.rotation);
					freezeBomb2.transform.parent = gameObject.transform;
					GameObject freezeBomb3 = (GameObject)Instantiate(freezeBombPrefab, new Vector3(transform.position.x + freezeBombDistance,transform.position.y, transform.position.z), transform.rotation);
					freezeBomb3.transform.parent = gameObject.transform;
					GameObject freezeBomb4 = (GameObject)Instantiate(freezeBombPrefab, new Vector3(transform.position.x - freezeBombDistance,transform.position.y, transform.position.z), transform.rotation);
					freezeBomb4.transform.parent = gameObject.transform;
					bomb--;
					gameController.SendMessage("bombInfo",bomb);
				}
			
				bombTime += Time.deltaTime;
				if (bombTime > bombInterval){
					bombTime = 0.0f;
					bombEnable = true;
				}

				break;


			case 2: //Thonder Mode

				if (Input.GetAxis("Fire1") == 1 && thonderBulletEnable){

					thonderBulletEnable = false;
	
					GameObject bullet = (GameObject)Instantiate(basicBulletPrefab, transform.position, transform.rotation);
					bulletVelocity = new Vector3(0, 0, fireBulletVelocity);
					bullet.transform.rigidbody.AddForce(bulletVelocity, ForceMode.VelocityChange); 
					
					Instantiate(ThonderBulletPrefab, transform.position, transform.rotation);

					if (thonderLevel > 0){
						GameObject thonderBullet2 = (GameObject)Instantiate(ThonderBulletPrefab, transform.position, transform.rotation);
						thonderBullet2.transform.Rotate(0,30,0);
						GameObject thonderBullet3 = (GameObject)Instantiate(ThonderBulletPrefab, transform.position, transform.rotation);
						thonderBullet3.transform.Rotate(0,-30,0);

						if (thonderLevel > 1){
							GameObject thonderBullet4 = (GameObject)Instantiate(ThonderBulletPrefab, transform.position, transform.rotation);
							thonderBullet4.transform.Rotate(0,60,0);
							GameObject thonderBullet5 = (GameObject)Instantiate(ThonderBulletPrefab, transform.position, transform.rotation);
							thonderBullet5.transform.Rotate(0,-60,0);

							if (thonderLevel > 2){

							}
						}
					}
					audio.PlayOneShot(thonderBulletSE);
				}

				basicBulletTime += Time.deltaTime;
				if (basicBulletTime > basicBulletInterval){
					basicBulletEnable = true;
					basicBulletTime = 0.0f;
				}


				bulletTime += Time.deltaTime;
				if (bulletTime > thonderBulletInterval){
					thonderBulletEnable = true;
					bulletTime = 0.0f;
				}


				//Thonder Bomb
				if (Input. GetAxis("Fire2") == 1 && bombEnable && bomb > 0){
					bombEnable = false;
					GameObject thonderBomb = (GameObject)Instantiate(thonderBombPrefab, transform.position, transform.rotation);
					//bomb.transform.rigidbody.AddForce(direction * bombVelocity, ForceMode.VelocityChange);
					thonderBomb.transform.Rotate(90,0,0);
					thonderBomb.transform.Translate(0,-(thonderBomb.transform.localScale.y + transform.localScale.z), 0);
					thonderBomb.transform.parent = gameObject.transform;
					//GameObject.Find ("Main Camera").SendMessage("setShakeTime",2.0f);
					mainCamera.SendMessage("setShakeTime",2.0f);

					bomb--;
					gameController.SendMessage("bombInfo",bomb);
				}
			
				bombTime += Time.deltaTime;
				if (bombTime > bombInterval){
					bombTime = 0.0f;
					bombEnable = true;
				}


				break;
			
			default:
				break;
		}

				
	}



	/* Level UP */

	//Fire
	void fireLevelUP(){
		fireLevel++;
	}

	//Freeze
	void freezeLevelUP(){
		freezeLevel++;
	}


	//Thonder
	void thonderLevelUP(){
		thonderLevel++;
	}

	//Player damage
	public void ApplyDamage(){
		Instantiate(explodePrefab, transform.position, transform.rotation);
		Object.Destroy(gameObject);
		gameController.SendMessage("PlayerDamage");
	}


}
