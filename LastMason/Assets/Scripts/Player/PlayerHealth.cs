using UnityEngine;
using System.Collections;

public class PlayerHealth : MonoBehaviour 
{
	public int health = 100;
	public int maxHealth;

	void Update()
	{
		if (health > maxHealth)
		{
			health = maxHealth;
		}

		if (health < 0)
		{
			// dead!
		}
	}

	public void TakeDamage(int amount)
	{
		health -= amount;
	}

	public void RestoreHealth(int amount)
	{
		health += amount;
	}
}
