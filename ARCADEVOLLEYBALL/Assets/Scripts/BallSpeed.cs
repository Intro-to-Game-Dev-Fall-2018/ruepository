using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSpeed : MonoBehaviour {

public float xMaxV = 10f;
public float yMaxV = 10f;
 
void Update () {
 
var rb = GetComponent<Rigidbody2D> ();
Vector3 vel = rb.velocity;
rb.velocity = new Vector3 (Mathf.Clamp(vel.x, -(xMaxV), xMaxV), Mathf.Clamp(vel.y, -(yMaxV), yMaxV), Mathf.Clamp(vel.z, 0f, 10f));
}
}