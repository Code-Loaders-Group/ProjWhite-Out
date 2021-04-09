using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BossScript : MonoBehaviour
{
    
    public float maxHealth = 20;
    public float currentHealth;

    //public BossHealth bossHealth;

    private float timeBtwShots;
    public float startTimeBtwShots;

    private Transform player;

    public GameObject projectile;
    // Start is called before the first frame update

    

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;

        timeBtwShots = startTimeBtwShots;

    }



    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.tag == "Player" || collision.gameObject.tag == "fireBall")
        {
            currentHealth = currentHealth - 1;

            if (currentHealth <= 0)
            {
                Destroy(this.gameObject);
                SceneManager.LoadScene("playerWins");
            }
        }
    }

        void Update()
        {
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
}
