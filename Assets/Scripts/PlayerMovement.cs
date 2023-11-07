using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //Variables for the rigidbody and movementspeed
    [SerializeField] private Rigidbody rb3d;
    [SerializeField] private float moveSpeed = 5f;

    void Update()
    {
        //This gets a direction and multiplies it by the movementspeed
        rb3d.velocity = new Vector3((Input.GetAxisRaw("Horizontal")), 0,(Input.GetAxisRaw("Vertical"))).normalized * moveSpeed; 
    }
}