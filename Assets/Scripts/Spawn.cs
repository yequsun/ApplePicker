using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;

public class Spawn : MonoBehaviour {
	public GameObject basketPrefab;
	public int numBaskets = 3;
	public float basketBottomY = -4.5f;
	public float basketSpacingY = 0f;
	public Text scoreText;
	public int score;

	public List<GameObject> basketList;
	// Use this for initialization
	void Start () {
		basketList = new List<GameObject> ();
		score = 0;

		for (int i=0; i<numBaskets; i++) {
			GameObject tBasketGo = Instantiate (basketPrefab) as GameObject;
			Vector3 pos = Vector3.zero;
			pos.y = basketBottomY + (basketSpacingY * i);
			tBasketGo.transform.position = pos;
			basketList.Add(tBasketGo);
		}
	
	}
	
	// Update is called once per frame
	void Update () {
		scoreText.text = "Score: " + score;
	
	}

	public void AppleDestroyed(){
		GameObject[] tAppleArray = GameObject.FindGameObjectsWithTag ("Apple");
		foreach (GameObject tgo in tAppleArray) {
			Destroy (tgo);
		}
		int basketIndex = basketList.Count - 1;
		GameObject tbasketGo = basketList [basketIndex];
		basketList.RemoveAt (basketIndex);
		Destroy (tbasketGo);

		if (basketList.Count == 0) {
			Application.LoadLevel (Application.loadedLevel);
		}
	}
}
