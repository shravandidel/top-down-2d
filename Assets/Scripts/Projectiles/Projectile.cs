using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private float moveSpeed;
    [SerializeField] private float attackDamage;

    private Vector3 direction;

    private void Start()
    {
        rb.velocity = transform.up * moveSpeed;    
    }

    public void SetProjectileDirection(Vector3 dir)
    {
        direction = dir;
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        Enemy enemy = collision.gameObject.GetComponent<Enemy>();


        if (enemy != null)
        {
            enemy.TakeDamage(attackDamage);
        }

        Destroy(gameObject);
    }
}

/*[HELP] The projectiles are behaving weird. */

/*
Im working on a 2d top down shooter game, while testing I noticed that the projectiles sometimes dont go where they are suppose to (to the mouse cursor). 
Gun code -> 
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour {
    [SerializeField] private GameObject projectilePrefab;
    [SerializeField] private float attackSpeed;
    private float attackDelay;
    private Vector3 direction;
    void Update()
    {
        if (Time.time > attackDelay)
        {
            if (Input.GetMouseButtonDown(0))
            {
                GameObject projectile = Instantiate(projectilePrefab, transform.position, transform.rotation);
                Projectile projectileScript = projectile.GetComponent<Projectile>();
                print($"transform.up -> {projectileScript.GetComponent<Transform>().up}");
                *//*projectileScript.SetProjectileDirection(transform.up.normalized);*//*
                attackDelay = Time.time + attackSpeed;
            }
        }
    }
}*/






/*
Projectile code -> 
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour {
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private float moveSpeed;
    [SerializeField] private float attackDamage;

    private Vector3 direction;

    private void Start()
    {
        rb.velocity = transform.up * moveSpeed;
    }

    public void SetProjectileDirection(Vector3 dir)
    {
        direction = dir;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Enemy enemy = collision.gameObject.GetComponent<Enemy>();
        if (enemy != null)
        {
            enemy.TakeDamage(attackDamage);
        }
        Destroy(gameObject);
    }
}

This is the issue */