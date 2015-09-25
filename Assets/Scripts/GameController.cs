using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameController : MonoBehaviour {
	public Text scoreText;
	private int score;

	public Text highScoreText;
	private static int highScore;

	// Use this for initialization
	void Start () {
		score = 0;
		scoreText.text = "";
		highScore = 1000;
		highScoreText.text = "High Score: " + highScore;
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void UpdateScore(){
		scoreText.text = score.ToString();
	}

	public void addScore(){
		score += 100;
		if (score > highScore) {
			highScore = score;
			highScoreText.text = "High Score: "+highScore;
		}
	}

}
