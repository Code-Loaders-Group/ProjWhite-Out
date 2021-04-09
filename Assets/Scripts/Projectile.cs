using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public float speed;

    private Transform player;
    private Vector2 target;
    public GameObject explosion;
    

    void Start()
    {
        // projectile ignores the boss here
        Physics2D.IgnoreLayerCollision(13, 12);
        //Ignores the fireball
        Physics2D.IgnoreLayerCollision(13, 6);


        player = GameObject.FindGameObjectWithTag("Player").transform;

        target = new Vector2(player.position.x, player.position.y);
    }
    
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, target, speed * Time.deltaTime);

        if(transform.position.x == target.x && transform.position.y == target.y)
        {
            DestroyProjectile();
        }
    }




    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Player"))
        {
            DestroyProjectile();
        }

        // if the projectile hits anything other than the player it will just explode the projectile
        else
        {
            DestroyProjectile();
            Instantiate(explosion, this.transform.position, this.transform.rotation);
        }
    }

    void DestroyProjectile()
    {
        Destroy(gameObject);
    }
}
