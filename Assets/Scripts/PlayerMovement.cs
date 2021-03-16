using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update
    //Rigidbody2D rb;
    public Animator animator;
    private float speed = 5f;
    float horizontal;
    float vertical;

    //public float runSpeed = 20.0f;

    void Start()
    {
        //body = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        
        horizontal = Input.GetAxisRaw("Horizontal");
        vertical = Input.GetAxisRaw("Vertical");
        Vector2 movement = new Vector2(horizontal, vertical);
        GetComponent<Rigidbody2D>().velocity = movement * speed;

        animator.SetFloat("Horizontal", horizontal);
        animator.SetFloat("Vertical", vertical);
        animator.SetFloat("Speed", movement.sqrMagnitude);
    }

    


        
    //private void FixedUpdate()
    //{
        //rb.velocity = new Vector2(horizontal * speed, vertical * speed);
    //}
}