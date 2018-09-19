using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TEAM1CONTROL : MonoBehaviour {
    public LayerMask whatIsGround;
    public Transform groundCheck;
    public bool isGrounded;
    public float jumpForce;
    public float speed;
    Rigidbody2D rb;
 
    void Start ()
    {
        rb = GetComponent <Rigidbody2D> ();
    }
 
    void Update () {
        if (Input.GetButtonDown ("p1_Jump") && isGrounded) {
            rb.AddForce (Vector2.up * jumpForce, ForceMode2D.Impulse);
            isGrounded = false;
        }
    }
 
    void FixedUpdate ()
    {
        isGrounded = Physics2D.OverlapPoint (groundCheck.position, whatIsGround);
        float x = Input.GetAxis ("p1_Horizontal");
        Vector3 move = new Vector3 (x * speed, rb.velocity.y, 0f);
        rb.velocity = move;
    }
}
