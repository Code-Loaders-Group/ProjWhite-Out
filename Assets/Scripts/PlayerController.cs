using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float speed;
    public float minX, minY, maxX, maxY;
    public GameObject laser, fireBallSpawner;
    public float fireRate = 0.25f;

    private float timer = 0;

    // Start is called before the first frame update
    void Start()
    {
        speed = 7;
    }

    // Update is called once per frame
    void Update()
    {
        float horiz, vert;
        horiz = Input.GetAxis("Horizontal");
        vert = Input.GetAxis("Vertical");
        //Debug.Log("H: " + horiz + ", V: " + vert);

        Vector2 newVelocity = new Vector2(horiz, vert);
        GetComponent<Rigidbody2D>().velocity = newVelocity * speed;

        //Add lazer fire code
        //Check if the "Fire1" button is pressed
        if(Input.GetAxis("Fire1") > 0 && timer > fireRate)
        {
            //If yes, spawn the lazer
            // Intastiation: What do I instantiate? Where is it instantiated from? What is its rotation?
            GameObject gObj;
            gObj = GameObject.Instantiate(laser, fireBallSpawner.transform.position, fireBallSpawner.transform.rotation);
            gObj.transform.Rotate(new Vector3(0, 0, 90));

            // Reset timer
            timer = 0;
        }

        timer += Time.deltaTime; //timer = timer + Time.deltatime

    }
}
