using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bossDoorTrigger : MonoBehaviour
{
    public GameObject bossDoor;
    public GameObject bossSpawner1;
    public GameObject bossSpawner2;
    public GameObject bossSpawner3;
    public GameObject bossSpawner4;
    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.tag == "Player")
        {
            bossDoor.SetActive(true);
            bossSpawner1.SetActive(true);
            bossSpawner2.SetActive(true);
            bossSpawner3.SetActive(true);
            bossSpawner4.SetActive(true);
            gameObject.SetActive(false);
        }
    }
}