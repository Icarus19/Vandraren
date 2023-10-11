using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private Rigidbody rb3d;
    [SerializeField] private float moveSpeed = 5f;
    private Vector3 input;

    void Update()
    {
        rb3d.velocity = new Vector3((Input.GetAxisRaw("Horizontal")), 0,(Input.GetAxisRaw("Vertical"))).normalized * moveSpeed; 
    }
}