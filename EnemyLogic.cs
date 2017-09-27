using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyLogic : MonoBehaviour {

	public GameObject enemyToSpawn;

	public bool canSpawn = true;

	public float enemySpawnTime;
	public float maxX = 28.0f;
	public float startingY = 28.0f;
	public float randomX = 0.0f;

	// Use this for initialization
	void Start () {
		StartCoroutine (spawnEnemyTimer());
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	IEnumerator spawnEnemyTimer() {
		while (canSpawn) {
			spawnEnemy ();
			yield return new WaitForSeconds (enemySpawnTime);
		}
	}

	void spawnEnemy() {
		randomX = Random.Range (-maxX, maxX);
		Instantiate (enemyToSpawn, new Vector3 (randomX, startingY, 0), Quaternion.identity);
	}
}
