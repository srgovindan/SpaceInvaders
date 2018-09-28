using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerControl : MonoBehaviour {

	public float modSpeed = 1;
	public float bulletOffset = .2f;

	Rigidbody2D rigidBody2D;

	// Use this for initialization
	void Start () {
		rigidBody2D = GetComponent<Rigidbody2D>(); //in C# the <Rigidbody2D> tells the function what kind of component we want to get
		Debug.Log(rigidBody2D.gravityScale); //console outputs the value of gravity scale in the rigidbody2D component
	}
	
	// Update is called once per frame
	void Update ()
	{
		Vector2 newForce = new Vector2(0, 0);
	
		if (Input.GetKey(KeyCode.RightArrow))
		{
			newForce.x = +modSpeed;
		}

		if (Input.GetKey(KeyCode.LeftArrow))
		{
			newForce.x += -modSpeed;
		}

		rigidBody2D.AddForce(newForce);

		if(Input.GetButtonDown("Fire1")){
			print("Fire!");
			GameObject shotsFired = Instantiate(Resources.Load("Prefabs/Bullet")) as GameObject;
			shotsFired.transform.position = new Vector2(transform.position.x,transform.position.y + bulletOffset);
		}
	}
}