using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update
    //used for the attack true or false logic ath the bottom
    public Rigidbody2D rb;
    //sword attack
    private bool isSwordAttack;

    //fireball attack
    private bool isFireBall;
    public GameObject fireBall, fireBallSpawner;
    //limits the amount of fireballs in the game at once;
    int howManyFireBall;

    //used to limit attack time and to not keep the sword attack on
    private float swordAttackTime = .15f;
    private float swordAttackCounter = .5f;

    //used to limit attack time and to not keep the fireball attack on
    private float fireAttackTime = .25f;
    private float fireAttackCounter = .25f;

    //for animations during movement
    public Animator animator;
    
    //for movement     
    private float speed = 5f;
    float horizontal;
    float vertical;
    
    void Start()
    {
        
    }

    void Update()
    {
        //counts how many fireballs are in the scene
        howManyFireBall = GameObject.FindGameObjectsWithTag("fireBall").Length;
        //for movement
        horizontal = Input.GetAxisRaw("Horizontal");
        vertical = Input.GetAxisRaw("Vertical");
        //movement here so we don't need to use speed in terms of animations and movement
        Vector2 movement = new Vector2(horizontal, vertical);
        
        //speed used here to manipulate movement speed while still having access
        //to the benifits of movement and the animations. 
        GetComponent<Rigidbody2D>().velocity = movement * speed;
        
        //to call the animations
        animator.SetFloat("Horizontal", horizontal);
        animator.SetFloat("Vertical", vertical);


        //conditions for which animations are accessed at which time through the animator window
        if (Input.GetAxisRaw("Horizontal") == 1 || Input.GetAxisRaw("Horizontal") == -1 || Input.GetAxisRaw("Vertical") == 1 || Input.GetAxisRaw("Vertical") == -1)
        {
            animator.SetFloat("lastHorizontal", Input.GetAxisRaw("Horizontal"));
            animator.SetFloat("lastVertical", Input.GetAxisRaw("Vertical"));
        }


        //to limit the attack time and not be stuck in attack loop. There are conditions for true and false
        if (isSwordAttack)
        {
            rb.velocity = Vector2.zero;
            swordAttackCounter -= Time.deltaTime;
            if (swordAttackCounter <=0)
            {
                //refers to the sword attack from the animator window (condition is false).
                animator.SetBool("isSwordAttack", false);
                isSwordAttack = false;
            }
        }

        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            //refers to the sword attack from the animator window (condition is true here).
            swordAttackCounter = swordAttackTime;
            animator.SetBool("isSwordAttack", true);
            isSwordAttack = true;
            SoundManager.PlaySound("swordSwing");      
        }

        if (isFireBall)
        {
            rb.velocity = Vector2.zero;
            fireAttackCounter -= Time.deltaTime;
            if (fireAttackCounter <= 0)
            {
                //refers to the fireBall attack from the animator window (condition is false).
                animator.SetBool("isFireBall", false);
                isFireBall = false;
            }
        }

        if (Input.GetKeyDown(KeyCode.Mouse1))
        {
            //refers to the fireBall attack from the animator window (condition is true here).
            
            fireAttackCounter = fireAttackTime;
            animator.SetBool("isFireBall", true);
            isFireBall = true;
            //add fireball spawner code
            //if conditions are true
            if (howManyFireBall < 1)
            {
                Instantiate(fireBall, fireBallSpawner.transform.position, fireBallSpawner.transform.rotation);
                SoundManager.PlaySound("fireBall");
            }
            
        }
    }
}