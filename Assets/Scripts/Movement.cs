using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public Vector3 direction;
    public float speed;
    public float livingTime = 5f;
    float speedRotation=5f;
    Vector3 rotationAxis;

    // Start is called before the first frame update
    void Start()
    {
        rotationAxis = new Vector3(0, 0, UnityEngine.Random.Range(5, -5)).normalized;
        Destroy(gameObject, livingTime);
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        transform.Translate(speed * direction.normalized * Time.deltaTime);
        transform.Rotate(rotationAxis,speedRotation*Time.deltaTime);
    }
}
