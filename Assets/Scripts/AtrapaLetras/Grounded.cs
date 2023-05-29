using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grounded : MonoBehaviour
{
    GameObject Player;
    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.collider.tag== "Ground")
        {
            Player.GetComponent<Move>().isGrounded = true;
        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.collider.tag == "Ground")
        {
            Player.GetComponent<Move>().isGrounded = false;
        }
    }
}
