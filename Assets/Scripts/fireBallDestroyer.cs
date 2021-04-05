using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fireBallDestroyer : MonoBehaviour
{
    public GameObject enemy_explosion;

    private void Start()
    {
        Physics2D.IgnoreLayerCollision(6, 7);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.tag == "enemy")
        {
            Destroy(collision.gameObject);
            Destroy(this.gameObject);
            Instantiate(enemy_explosion, transform.position, transform.rotation);
        }
        else Destroy(this.gameObject);
    }
}
