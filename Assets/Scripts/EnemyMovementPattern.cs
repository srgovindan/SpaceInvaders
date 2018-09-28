using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovementPattern : MonoBehaviour
{

	public float speed = 4;
	Rigidbody2D rigidBody2D;

	// Use this for initialization
	void Start () {
		rigidBody2D = GetComponent<Rigidbody2D>();
		
		rigidBody2D.velocity = Vector2.down * speed; 
	}
	
	// Update is called once per frame
	void Update () {
	}
}
