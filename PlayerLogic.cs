using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerLogic : MonoBehaviour {

	//projectile variables
	public GameObject projectile;
	public float shootingSpeed = 0.5f;
	public bool isShooting = true;

	public float playerSpeed = 1.0f;
	public float maxPlayerDistance = 29.0f;
	public GameObject enemy;

	// Use this for initialization
	void Start () {
		StartCoroutine (projectileShootTimer ());

	}
	
	// Update is called once per frame
	void Update () {
		playerMovement ();
	}

	void playerMovement() {
		if (Input.GetKey (KeyCode.A) && transform.position.x >= -maxPlayerDistance) {
			transform.Translate (-playerSpeed, 0, 0);
		}
		if (Input.GetKey (KeyCode.D) && transform.position.x <= maxPlayerDistance) {
			transform.Translate (playerSpeed, 0, 0);
		}
	}

	IEnumerator projectileShootTimer() {
		while (isShooting == true) {
			spawnProjectile ();
			yield return new WaitForSeconds(shootingSpeed);
		}
	}

	void spawnProjectile() {
		Instantiate (projectile, transform.position, Quaternion.identity);
	}
		
	}

