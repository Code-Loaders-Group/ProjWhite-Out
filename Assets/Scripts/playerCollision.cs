using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playerCollision : MonoBehaviour
{
    // for when the boss projectile hits the player
    public GameObject explosion;
    // timer to see the player explode.
    
    
    float timer = 0;
    public void Update()
    {
        
        timer += Time.deltaTime;
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        
        // when enemy touches player
        if (other.gameObject.tag == "enemy" ||  other.gameObject.tag == "boss")
        {
            SceneManager.LoadScene("gameOver");
            //Destroy(other.gameObject);
        }

        if (other.gameObject.tag == "projectile")
        {
            
            

            Instantiate(explosion, other.transform.position, other.transform.rotation);
            
            
            // delay between explosion and death so you can see the player explode
            if (timer >= 1.0f)
            {
                SceneManager.LoadScene("gameOver");
                timer = 0;
            }
            
        }

    }
}