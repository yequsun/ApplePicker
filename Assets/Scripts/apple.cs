using UnityEngine;
using System.Collections;

public class apple : MonoBehaviour {
	public static float bottomY = -20f;
	private GameObject gameControllerObj;
	private GameController gameController;

	// Use this for initialization
	void Start () {
		gameControllerObj = GameObject.FindGameObjectWithTag ("GameController");
		gameController = gameControllerObj.GetComponent<GameController> ();

	
	}
	
	// Update is called once per frame
	void Update () {
		if (transform.position.y < bottomY) {
			Destroy (this.gameObject);
			Spawn sp = Camera.main.GetComponent<Spawn> ();
			sp.AppleDestroyed ();
		}


	
	}

	void OnTriggerEnter(Collider other){
		if (other.tag =="Basket"){
			gameController.addScore();
			gameController.UpdateScore();
			Destroy(gameObject);
		}
	}
}
