using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lab03_3 : MonoBehaviour
{
    public float speed = 1.0f;
    float distance = 0.0f;

    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (distance >= 10.0f)
        {
            transform.Rotate(new Vector3(0, 90, 0));
            distance = 0.0f;
        }
        transform.position += transform.forward * speed * Time.deltaTime;
        distance += speed * Time.deltaTime;
    }
}
