﻿using UnityEngine;
using System.Collections;

public class apple : MonoBehaviour {
	public static float bottomY = -20f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (transform.position.y < bottomY) {
			Destroy (this.gameObject);
		}
	
	}

	void OnTriggerEnter(Collider other){
		if (other.tag =="Basket"){
			Destroy(gameObject);
		}
	}
}
