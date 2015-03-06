using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour 
{
	public float maxSpeed;

	void FixedUpdate()
	{
		float move = Input.GetAxis("Horizontal");
		GetComponent<Rigidbody2D>().velocity = new Vector2(move * maxSpeed, GetComponent<Rigidbody2D>().velocity.y);
	}
}
