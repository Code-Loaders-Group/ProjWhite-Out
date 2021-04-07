using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bossDoorTrigger : MonoBehaviour
{
    public GameObject bossDoor;
    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.tag == "Player")
        {
            bossDoor.SetActive(true);
            gameObject.SetActive(false);
        }
    }
}