using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class randomMovements : MonoBehaviour
{
   float fMinX = 50.0f;
float fMaxX = 250.0f;
int Direction = -1;
 
Update:
 
switch( Direction )
{
    case -1:
        // Moving Left
        if( fEnemyX > fMinX )
        {
            fEnemyX -= 1.0f;
        }
        else
        {
            // Hit left boundary, change direction
            Direction = 1;
        }
        break;
     
    case 1:
        // Moving Right
        if( fEnemyX < fMaxX )
        {
            fEnemyX += 1.0f;
        }
        else
        {
            // Hit right boundary, change direction
            Direction = -1;
        }
        break;
}
 
sprEnemy.transform.localPosition = new Vector3( fEnemyX , 0.0f , 0.0f );
}
