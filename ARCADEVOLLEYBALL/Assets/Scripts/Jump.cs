using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
	public float playerSpeed;
	public Vector2 jumpHeight;
	void Update()
	{
		transform.Translate(playerSpeed * Time.deltaTime, 0f, 0f); //makes player run

		if (Input.GetMouseButtonDown(0) || Input.GetKeyDown(KeyCode.Space)) //makes player jump
		{
			GetComponent<Rigidbody2D>().AddForce(jumpHeight, ForceMode2D.Impulse);
		}
	}
}