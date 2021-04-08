using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class swordColliders : MonoBehaviour
{

    //To destroy the enemy with sword attack and to instantiate the animation for the sword attack
    // This is calling the animation

    public GameObject swordSlash;

    // Start is called before the first frame update
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "enemy")
        {
            Destroy(other.gameObject);
            // calling the sword animation here.
            Instantiate(swordSlash, other.transform.position, other.transform.rotation);
        }
    }
}
