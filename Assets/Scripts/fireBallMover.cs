using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fireBallMover : MonoBehaviour
{
    private float speed = 10f;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Rigidbody2D>().velocity = new Vector2(speed, 0.0f);
    }
}
