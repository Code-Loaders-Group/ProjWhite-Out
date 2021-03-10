using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    public float speed = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float horiz, vert;


        horiz = Input.GetAxis("Horizontal"); //listens to my input
        vert = Input.GetAxis("Vertical");
        //(dont need the Debug part right now because it just shows us the value being used for x and y movement):
        //Debug.Log("H: " + horiz + ", V: " + vert); //prints out number. But Uity and visual studio work to display this is Unity.
        //use velocity to reflect input next
        //specifying component in unity to manipulate here
        //velocity is speed and direction. Vector 2 a container for two pieces of data x and y(they are combined. vert and horiz are the x and y
        //so just feed them to the Vector2 as values.

        Vector2 newVelocity = new Vector2(horiz, vert);
        GetComponent<Rigidbody2D>().velocity = newVelocity * speed;
    }
}
