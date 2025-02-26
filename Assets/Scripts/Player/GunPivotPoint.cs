using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class GunPivotPoint : MonoBehaviour
{
    [SerializeField] private GameObject target;

    private Camera m_camera; 

    void Start()
    {
        m_camera = Camera.main;
    }

    void Update()
    {
        /*Vector3 input = Input.mousePosition;

        Vector3 mousePosition = m_camera.ScreenToWorldPoint(new Vector3(input.x, input.y, m_camera.transform.position.y));*/


        /*Vector3 direction = (mousePosition - transform.position).normalized;*/

        Vector3 direction = (target.transform.position - transform.position).normalized;


        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0, 0, angle - 90);
    }
}
