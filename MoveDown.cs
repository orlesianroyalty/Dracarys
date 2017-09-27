using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveDown : MonoBehaviour {

	public float enemySpeed = 0.1f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		moveToBottom ();
	}

	void moveToBottom() {
		transform.Translate (0, -enemySpeed, 0);
	}
}
