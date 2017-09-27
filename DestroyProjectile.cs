using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;


public class DestroyProjectile : MonoBehaviour {

	public Text amount;

	// Use this for initialization
	void Start () {
		amount = GameObject.Find ("amount").GetComponent<Text>();
	}

	// Update is called once per frame
	void Update () {
		if (int.Parse (amount.text) == 50) {
			SceneManager.LoadScene ("Scenes/WinScene");
		}
	}

	void OnCollisionEnter2D(Collision2D transformCollision) {
		if (transformCollision.gameObject.tag == "Projectile") {
			IncrementCount ();
			Destroy (transformCollision.gameObject);
			Destroy (gameObject);
		}
	}

	void IncrementCount() {
		amount.text = int.Parse(amount.text) + 1 + "";
	}
		


}
