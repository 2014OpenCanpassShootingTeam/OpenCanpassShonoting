using UnityEngine;
using System.Collections;

public class BackScript : MonoBehaviour {

	public float speed = 0.1f;
	private float y;
	private Vector2 offset;
	
	// Use this for initialization
	void Start () {
		y = 0;
	}
	
	// Update is called once per frame
	void Update () {
		
		y = Mathf.Repeat(Time.time * speed, 1);
		
		offset = new Vector2(0, y);
		
		renderer.sharedMaterial.SetTextureOffset("_MainTex", offset);
		
	}
}
