using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class randomMovements : MonoBehaviour
{
    // Assigns the end position to the player
    public Transform target;
    public float speed = 3f;


    public void Start()
    {
        
    }

    void Update()
     {
        //Moves the enemy towards the player using only Vector2, this way we don't get the weird spinning like before
        transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
        
        
        //old enemy mover script to follow player

         //transform.LookAt(target.position);
         //transform.Rotate(new Vector3(0, -90, 0), Space.Self);

        //if (Vector3.Distance(transform.position,target.position)>1f){
        //     transform.Translate(new Vector3(speed* Time.deltaTime,0,0) );
        //}
 
     }
 
 }
 


