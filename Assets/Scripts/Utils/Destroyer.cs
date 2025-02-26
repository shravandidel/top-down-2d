using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyer : MonoBehaviour
{
    [SerializeField] private float destroyInSeconds;

    void Start()
    {
        Destroy(gameObject, destroyInSeconds); 
    }

}
