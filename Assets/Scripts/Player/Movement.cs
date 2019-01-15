using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

	[SerializeField] private float playerSpeedPerSecond;
	
	private Rigidbody2D rb2d;       //Store a reference to the Rigidbody2D component required to use 2D Physics.

	// Use this for initialization
	void Start()
	{
		//Get and store a reference to the Rigidbody2D component so that we can access it.
		rb2d = GetComponent<Rigidbody2D> ();
	}
	
	void FixedUpdate()
	{
		Vector2 movement = UpdatedPosition("d", Vector2.right)+UpdatedPosition("a", Vector2.left)+UpdatedPosition("w", Vector2.up)+UpdatedPosition("s", Vector2.down);

		//Call the AddForce function of our Rigidbody2D rb2d supplying movement multiplied by speed to move our player.
		rb2d.velocity = movement * playerSpeedPerSecond;

	}

	private Vector2 UpdatedPosition(string key ,Vector2 moveVector)
	{	
		if (Input.GetKey(key))
		{
			return moveVector;
		}
		return new Vector2();
	}
}
