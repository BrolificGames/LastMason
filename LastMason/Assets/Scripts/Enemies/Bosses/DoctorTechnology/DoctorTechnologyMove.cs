using UnityEngine;
using System.Collections;

public class DoctorTechnologyMove : MonoBehaviour 
{
	void FixedUpdate() 
	{
		Hover();
	}

	private void Hover()
	{
		RaycastHit2D rayHit = Physics2D.Raycast(transform.position, -Vector2.up, 1f);
		if (rayHit.collider != null && rayHit.collider.tag == "Ground")
		{
			Debug.Log(rayHit.collider.tag);
		}
	}
}
