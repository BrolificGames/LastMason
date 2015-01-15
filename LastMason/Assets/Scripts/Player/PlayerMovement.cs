using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour 
{
	public float maxSpeed;

	void FixedUpdate()
	{
		float move = Input.GetAxis("Horizontal");
		rigidbody2D.velocity = new Vector2(move * maxSpeed, rigidbody2D.velocity.y);
	}
}
