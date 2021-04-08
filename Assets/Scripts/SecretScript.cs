using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecretScript : MonoBehaviour
{
    public GameObject secretWall;
    public GameObject secretRoom;
    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "fireBall")
        {
            secretRoom.SetActive(true);
         
            secretWall.SetActive(false);
            gameObject.SetActive(false);
        }
    }

}
