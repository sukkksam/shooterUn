using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereMover : MonoBehaviour
{
    public Vector3 direction;
    public float speed;

    void Update()
    {
        transform.Translate(direction * speed * Time.deltaTime);
    }
}