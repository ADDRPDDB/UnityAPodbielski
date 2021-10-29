using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lab03_2 : MonoBehaviour
{
    public float speed = 1.0f;
    int direction = 1;
    Vector3 startPosition;

    void Start()
    {
        startPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x >= startPosition.x + 10)
            direction = -1;
        else if (transform.position.x <= startPosition.x)
            direction = 1;

        transform.Translate(direction*speed * Time.deltaTime, 0, 0);
    }
}
