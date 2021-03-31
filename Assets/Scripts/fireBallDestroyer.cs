using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fireBallDestroyer : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.tag == "enemy")
        {
            Destroy(collision.gameObject);
            Destroy(this.gameObject);
        }
        else Destroy(this.gameObject);
    }
}
