using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private float moveSpeed;

    void FixedUpdate()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        rb.velocity = new Vector2(horizontalInput,verticalInput) * moveSpeed;
    }
}
