using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fireBallDestroyer : MonoBehaviour
{
    public GameObject explosion;
    public void Update()
    {
        Physics2D.IgnoreLayerCollision(6, 7);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.tag == "enemy")
        {
            Destroy(collision.gameObject);
            Destroy(this.gameObject);
            Instantiate(explosion, collision.transform.position, collision.transform.rotation);
        }
        else Destroy(this.gameObject);
    }
}
