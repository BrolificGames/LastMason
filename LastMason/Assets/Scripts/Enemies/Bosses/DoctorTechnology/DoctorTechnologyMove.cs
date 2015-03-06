using UnityEngine;
using System.Collections;

public class DoctorTechnologyMove : MonoBehaviour 
{
	public float hoverHeight;
	public float hoverForce;
	private Rigidbody2D parentRigidBody;

	void Awake()
	{
		parentRigidBody = transform.parent.GetComponent<Rigidbody2D>();
	}

	void FixedUpdate() 
	{
		Hover();
	}

	private void Hover()
	{
		RaycastHit2D rayHit = Physics2D.Raycast(transform.position, -Vector2.up, 1f);
		if (rayHit.collider != null && rayHit.collider.tag == "Ground")
		{
			if (rayHit.distance < hoverHeight)
			{
				float hoverForceMultiplyer = (hoverHeight - rayHit.distance) / hoverHeight;
				Vector2 hover = (Vector2.up * hoverForce * hoverForceMultiplyer);
				parentRigidBody.AddForce(hover * Time.deltaTime);
			}
		}
	}
}
