using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class BossScript : MonoBehaviour
{
    
    public int maxHealth = 20;
    public int currentHealth;

    public BossHealth bossHealth;

    private float timeBtwShots;
    public float startTimeBtwShots;

    private Transform player;

    public GameObject projectile;
    // Start is called before the first frame update

    

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;

        timeBtwShots = startTimeBtwShots;

        currentHealth = maxHealth;
        bossHealth.SetMaxHealth(maxHealth);
    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject.tag == "Player" || gameObject.tag == "fireBall")
        {
            TakeDamage(5);
        }


        if (timeBtwShots <= 0)
        {
            Instantiate(projectile, transform.position, Quaternion.identity);
            timeBtwShots = startTimeBtwShots;
        }
        else
        {
            timeBtwShots -= Time.deltaTime;
        }

    }

    void TakeDamage(int damage)
    {
        currentHealth -= damage;

        bossHealth.SetHealth(currentHealth);
    }

}
