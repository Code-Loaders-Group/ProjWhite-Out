using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody2D rb;
    public Animator animator;
    private float speed = 5f;
    float horizontal;
    float vertical;
    private float attackTime = .25f;
    private float attackCounter = .25f;
    private bool isSwordAttack;

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

        if (Input.GetAxisRaw("Horizontal") == 1 || Input.GetAxisRaw("Horizontal") == -1 || Input.GetAxisRaw("Vertical") == 1 || Input.GetAxisRaw("Vertical") == -1)
        {
            animator.SetFloat("lastHorizontal", Input.GetAxisRaw("Horizontal"));
            animator.SetFloat("lastVertical", Input.GetAxisRaw("Vertical"));
        }

        if (isSwordAttack)
        {
            rb.velocity = Vector2.zero;
            attackCounter -= Time.deltaTime;
            if (attackCounter <=0)
            {
                animator.SetBool("isSwordAttack", false);
                isSwordAttack = false;
            }
        }

        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            attackCounter = attackTime;
            animator.SetBool("isSwordAttack", true);
            isSwordAttack = true;

        }
    }

    


        
    //private void FixedUpdate()
    //{
        //rb.velocity = new Vector2(horizontal * speed, vertical * speed);
    //}
}