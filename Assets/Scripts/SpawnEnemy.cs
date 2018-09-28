using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour {

	public float spawnTime = 2;
	public float spawnAcel = 0.1f;
	public float startPos = 8;
	public float xLimit = 7;

	public PlayerControl playerControl;

	// Use this for initialization
	void Start () {
		Invoke("MakeEnemy", spawnTime);
		// Invoke is a very useful function in Unity, it calls a function that you specify after a set period of time
		// Invoke repeating calls a function recursively
	}
	
	// Update is called once per frame
	void Update () {
	}

	void MakeEnemy(){
		GameObject newEnemy = Instantiate(Resources.Load("Prefabs/Enemy")) as GameObject;
		// as GameObject tells the computer, yo we're giving you a GameObject
		// Prefabs are like templates of game objects so you can call them when you want

		newEnemy.transform.position = 
			new Vector2(Random.Range(-xLimit, xLimit),
						startPos + Random.Range(1, 4));

		spawnTime -= spawnAcel;
		Invoke("MakeEnemy", spawnTime);
	}
}
