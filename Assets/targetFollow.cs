using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class targetFollow : MonoBehaviour
{
    [SerializeField] private Camera m_Camera; // keeping the naming scheme that you used

    private void Start()
    {
        m_Camera = Camera.main;
        // There is only have the one camera in the scene and it's automatically the main camera.
        // You have the right idea of caching the camera reference in Start() to avoid calling Camera.main every frame, like I do in my script, I think.
    }

    private void Update()
    {
        if (m_Camera != null)
        {
            transform.position = m_Camera.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 0));
        }
    }
}
