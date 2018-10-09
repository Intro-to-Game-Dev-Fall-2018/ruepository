using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallCollision : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.collider.tag == "PlusCounterSurface")
        {
            FindObjectOfType<AudioManager>().Play("Bop");
        }
        else if (col.collider.tag == "Player")
        {
            FindObjectOfType<AudioManager>().Play("Boop");
        }
        
    }
    

}
