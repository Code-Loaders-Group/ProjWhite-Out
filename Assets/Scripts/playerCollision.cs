using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playerCollision : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D other)
    {
        // when enemy touches player
        if (other.gameObject.tag == "enemy")
        {
            SceneManager.LoadScene("gameOver");
            //Destroy(other.gameObject);
        }
    }
}