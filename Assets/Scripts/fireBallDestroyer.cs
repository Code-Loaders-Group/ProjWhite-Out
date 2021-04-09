using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fireBallDestroyer : MonoBehaviour
{
    public GameObject fireBall;


    public GameObject explosion;

    public void Start()
    {
        Physics2D.IgnoreLayerCollision(6, 7);
        // To ignore the invisible spawn triggers (It's very buggy)
        Physics2D.IgnoreLayerCollision(6, 11);
    }



 
    private void OnCollisionEnter2D(Collision2D collision)
    {



        if (collision.gameObject.tag == "enemy")
        {
            Destroy(collision.gameObject);
            Destroy(this.gameObject);
            Instantiate(explosion, collision.transform.position, collision.transform.rotation);
        }
        // this ensure that the fireball explodes when it hits the walls, but it does not destroy the walls
        else if (collision.gameObject.tag == "walls" || collision.gameObject.tag == "bossDoor")
        {
            Destroy(this.gameObject);
            Instantiate(explosion, fireBall.transform.position, fireBall.transform.rotation);
        }
        else
        {
            // for fires, spawners and anything that is not an enemy
            Destroy(this.gameObject);
            Instantiate(explosion, fireBall.transform.position, fireBall.transform.rotation);
        }
    }
}
