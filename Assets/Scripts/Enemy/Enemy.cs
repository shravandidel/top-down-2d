using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private float moveSpeed;
    [SerializeField] private float health;

    private GameObject playerGameObject;

    private void FixedUpdate()
    {
            Vector3 direction = (playerGameObject.transform.position - transform.position).normalized;
            Movement(direction);
    }

    private void Movement(Vector3 direction)
    {
        rb.velocity = direction * moveSpeed;
    }

    public void TakeDamage(float damage)
    {
        health -= damage;

        if (health < 0)
        {
            Destroy(gameObject);
        }
    }


    public void SetPlayerReference(GameObject playerRef)
    {
        playerGameObject = playerRef;
    }

}
