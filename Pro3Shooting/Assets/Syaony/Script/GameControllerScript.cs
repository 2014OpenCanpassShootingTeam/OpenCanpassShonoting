using UnityEngine;
using System.Collections;

public class GameControllerScript : MonoBehaviour {

	//Screen size
	private float screenWidth;
	private float screenHeight;


	/*Score*/
	private int score;
	//score position
	private float statusPositionX;
	
	//GUIStyle
	public GUIStyle labelStyle;
	public GUIStyle gameoverStyle;
	public GUIStyle statusStyle;
	public GUIStyle experienceBackStyle;
	public GUIStyle fireExperienceStyle;

	/* Player Status */
	private GameObject gamePlayer;
	//public Texture experienceBackTexture;
	private float statuslength;
	//Fire
	private int fireLevel = 0;
	private int fireNextExperience;
	private float fireParsentage;
	public int[] fireExperience = new int[]{10,20,30};
	public Texture fireExperienceTexture;
	//Freeze
	private int freezeLevel = 0;
	private int freezeNextExperience;
	private float freezeParsentage;
	public int[] freezeExperience = new int[]{10,20,30};
	//Thonder
	private int thonderLevel = 0;
	private int thonderNextExperience;
	private float thonderParsentage;
	public int[] thonderExperience = new int[]{10,20,30};


	/* Bomb */
	private int bomb;
	public GUIStyle bombTexture;

	//Explode SE
	public AudioClip explodeSE;

	//
	private bool isPlay;


	// Use this for initialization
	void Start () {
		screenWidth = Screen.width;
		screenHeight = Screen.height;

		statusPositionX = screenWidth/10*7+20;

		statuslength = Screen.width/10*3-40;

		isPlay = true;

		gamePlayer = GameObject.Find("Player");
	}
	
	
	void OnGUI(){
		
		if (isPlay){

			/* Score */
			GUI.Label (new Rect(statusPositionX,20, screenWidth, screenHeight), "Score", labelStyle);
			GUI.Label (new Rect(statusPositionX+30,screenHeight/10, screenWidth, screenHeight), ""+score, labelStyle);

			/* Bomb */
			GUI.Label (new Rect(statusPositionX,screenHeight/5, screenWidth, screenHeight), "Bomb", labelStyle);
			GUI.Label (new Rect(statusPositionX, screenHeight/10*3, 50, 50), "X" + bomb ,bombTexture);
			//GUI.Label (new Rect(statusPositionX, screenHeight/10*4, 50, 50), "X" + bomb, bombTexture);

			/* Level */
			//Fire
			GUI.Label (new Rect(statusPositionX, screenHeight/10*4, 50, 50), "Fire Level"+fireLevel, labelStyle);
			//GUI.Label (new Rect(statusPositionX+20, screenHeight/10*5, 50, 50), ""+fireNextExperience + "/" + fireExperience[fireLevel],labelStyle);
			GUI.Label (new Rect(statusPositionX, screenHeight/2, statuslength, 10), "", experienceBackStyle);
			GUI.Label (new Rect(statusPositionX, screenHeight/2, fireParsentage, 10), "", fireExperienceStyle);
			//Freeze
			GUI.Label (new Rect(statusPositionX, screenHeight/10*6, 50, 50), "Freeze Level"+freezeLevel, labelStyle);
			GUI.Label (new Rect(statusPositionX, screenHeight/10*7, 50, 50), ""+freezeNextExperience + "/" + freezeExperience[freezeLevel],labelStyle);
			//GUI.Label (new Rect(statusPositionX+20, screenHeight/2, screenWidth/5,20),"", experienceBackStyle);
			//GUI.Label (new Rect(statusPositionX+20, screenHeight/2, screenWidth/5*fireParsentage,20),"", fireExperienceStyle);
			GUI.Label (new Rect(statusPositionX, screenHeight/10*8, 50, 50), "Thonder Level"+thonderLevel, labelStyle);
			GUI.Label (new Rect(statusPositionX, screenHeight/10*9, 50, 50), ""+thonderNextExperience + "/" + thonderExperience[thonderLevel],labelStyle);


		} else {
			GUI.Label (new Rect(screenWidth/2 - 130, screenHeight/2 - 50, 100, 50), "Game Over", gameoverStyle);
			GUI.Label (new Rect(screenWidth/2 - 120, screenHeight/2, 100, 50), "Score : "+score, gameoverStyle);
		}
	}


	/* Score */
	void GetScore(int _Score){
		audio.PlayOneShot(explodeSE);
		score += _Score;
	}
	
	void PlayerDamage(){
		audio.PlayOneShot(explodeSE);
		isPlay = false;
	}



	/* Bomb */
	void bombInfo(int bombNumber){
		bomb = bombNumber;
	}



	//Get fire experience
	void getFireExperience(int experience){
		fireNextExperience += experience;
		fireParsentage = statuslength * fireNextExperience / fireExperience[fireLevel];
		if (fireExperience[fireLevel] == fireNextExperience){
			fireLevel++;
			fireNextExperience = 0;
			gamePlayer.SendMessage("fireLevelUP");
		}
	}

	//Get freeze experience
	void getFreezeExperience(int experience){
		freezeNextExperience += experience;
		freezeParsentage = statuslength * freezeNextExperience / freezeExperience[freezeLevel];
		if (freezeExperience[freezeLevel] == freezeNextExperience){
			freezeLevel++;
			freezeNextExperience = 0;
			gamePlayer.SendMessage("freezeLevelUP");
		}
	}

	//Get Thonder experience
	void getThonderExperience(int experience){
		thonderNextExperience += experience;
		thonderParsentage = statuslength * thonderNextExperience / thonderExperience[thonderLevel]; 
		if (thonderExperience[thonderLevel] == thonderNextExperience){
			thonderLevel++;
			thonderNextExperience = 0;
			gamePlayer.SendMessage("thonderLevelUP");
		}
	}

}
