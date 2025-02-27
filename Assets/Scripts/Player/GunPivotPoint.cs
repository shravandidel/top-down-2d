using UnityEngine;

public class GunPivotPoint : MonoBehaviour
{
    [SerializeField] private GameObject target;

    void Update()
    {

        Vector2 direction = (target.transform.position - transform.position).normalized;
        // Lets make this a vector2, we're in 2D space, no need for 3D vectors.


        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0, 0, angle - 90);
    }
}
