using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TEAM2CONTROL : MonoBehaviour {
	bool isGrounded = true;
	public float jumpForce;
	public float speed;
	Rigidbody2D rb;
 
	void Start ()
	{
		rb = GetComponent <Rigidbody2D> ();
	}
 
	void Update () {
		if (Input.GetButtonDown ("p2_Jump") && isGrounded == true) {
			rb.velocity = new Vector2(rb.velocity.x, jumpForce);
			isGrounded = false;
			;
		}
	}
 
	void FixedUpdate ()
	{
		float x = Input.GetAxis ("p2_Horizontal");
		Vector3 move = new Vector3 (x * speed, rb.velocity.y, 0f);
		rb.velocity = move;
	}
	void OnCollisionEnter2D(Collision2D collisionInfo)
	{
		if (collisionInfo.gameObject.tag == "ground")
		{
			isGrounded = true;
		}
	}
}
