using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyWallIgnore : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //For enemies to have full collider to get hit but to ignore walls
        Physics2D.IgnoreLayerCollision(10, 0);


    }

}
