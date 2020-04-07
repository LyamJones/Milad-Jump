using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour {

	public float jumpForce = 10f;

	void OnCollisionEnter2D(Collision2D collision)
	{
		//activate only when comming from above
		if (collision.relativeVelocity.y <= 0f)
		{
			Rigidbody2D rb = collision.collider.GetComponent<Rigidbody2D>();
			if (rb != null)
			{
				//getting vector
				Vector2 velocity = rb.velocity;
				//modifiying component of the vector
				velocity.y = jumpForce;
				//setting back to vector
				rb.velocity = velocity;
			}
		}
	}

}
