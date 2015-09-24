using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Spawn : MonoBehaviour {
	public GameObject basketPrefab;
	public int numBaskets = 3;
	public float basketBottomY = -4.5f;
	public float basketSpacingY = 0f;
	public Text scoreText;
	public int score;
	// Use this for initialization
	void Start () {
		score = 0;

		for (int i=0; i<numBaskets; i++) {
			GameObject tBasketGo = Instantiate (basketPrefab) as GameObject;
			Vector3 pos = Vector3.zero;
			pos.y = basketBottomY + (basketSpacingY * i);
			tBasketGo.transform.position = pos;
		}
	
	}
	
	// Update is called once per frame
	void Update () {
		scoreText.text = "Score: " + score;
	
	}
}
