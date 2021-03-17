using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class randomMovements : MonoBehaviour
{
   public float moveSpeed = 3f;
   Transform leftWayPoint, rightWayPoint;
   Vector3 localScale;
   bool movingRight = true;
   RigidBody2D rb;
   
 void Start () {
 localScale = transform.localScale;
 rb = GetComponent<RigidBody2D>();
 leftWayPoint = GameObject.Find("LeftWayPoint").GetComponent<Transform>();
 rightWayPoint = GameObject.Find("RightWayPoint").GetComponent<Transform>();
 
 }
 void Update () {
 if (transform.position.x > rightWayPosition.position.x)
 movingRight = false;
 if (transform.position.x < leftWayPosition.position.x)
 movingRight = true;
 
 if (movingRight)
 moveRight();
 else 
 moveLeft();
 }
 void moveRight () {
 movingRight = true;
 localScale.x = 1;
 transfrom.localScale = localScale;
 rb.velocity = new Vector2 (localScale.x * moveSpeed, rb.velocity.y);
 }
 
 void moveLeft () {
 movingRight = false;
 localScale.x = -1;
 transfrom.localScale = localScale;
 rb.velocity = new Vector2 (localScale.x * moveSpeed, rb.velocity.y);
 }
 
 }

