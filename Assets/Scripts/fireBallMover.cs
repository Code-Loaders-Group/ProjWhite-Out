using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fireBallMover : MonoBehaviour
{
    public float speed = 10f;

    public float lifespan = 3f;

    void Start()
    {
        GetComponent<Rigidbody2D>().velocity = new Vector2(speed, 0.0f);
        Destroy(gameObject, lifespan);
    }
}
