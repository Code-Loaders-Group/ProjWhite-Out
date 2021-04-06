using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fireBallDestroyer : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        //for fireball to ignore the player's collider.
        if (collision.gameObject.tag == "Player")
        {
            Physics.IgnoreLayerCollision(6, 7);
        }



        if (collision.gameObject.tag == "enemy")
        {
            Destroy(collision.gameObject);
            Destroy(this.gameObject);
        }
        else Destroy(this.gameObject);
    }
}
