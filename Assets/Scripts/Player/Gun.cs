using UnityEngine;

public class Gun : MonoBehaviour
{
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
               GameObject projectile = Instantiate(projectilePrefab,transform.position,transform.rotation);

                Projectile projectileScript = projectile.GetComponent<Projectile>();

                print($"transform.up -> {projectileScript.GetComponent<Transform>().up}");
                /*projectileScript.SetProjectileDirection(transform.up.normalized);*/

                attackDelay = Time.time + attackSpeed;

            }
        }
    }

}
