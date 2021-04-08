using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlomanSpawnTrigger : MonoBehaviour
{
    public GameObject slomanSpawny1;
    public GameObject slomanSpawny2;
    public GameObject slomanSpawny3;
    public GameObject slomanSpawny4;
    public GameObject slomanSpawny5;
    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.tag == "Player")
        {
            slomanSpawny1.SetActive(true);
            slomanSpawny2.SetActive(true);
            slomanSpawny3.SetActive(true);
            slomanSpawny4.SetActive(true);
            slomanSpawny5.SetActive(true);
            gameObject.SetActive(false);
        }
    }
}
