using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fireBallDestroyer : MonoBehaviour
{

    public void Start()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.tag == "Player")
        {
            Physics2D.IgnoreLayerCollision(6, 7);
        }

        if (collision.gameObject.tag == "enemy")
        {
            Destroy(collision.gameObject);
            Destroy(this.gameObject);
        }
        else Destroy(this.gameObject);
    }
}
