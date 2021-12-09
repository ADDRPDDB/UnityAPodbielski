using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lab05_1 : MonoBehaviour
{
    // Start is called before the first frame update
    public float offsetX = 50.0f;
    public float offsetZ = 0.0f;
    public float speed = 10.0f;
    private bool collisionDetected = false;
    private Vector3 initialPosition;
    private float remainingZ;
    private float remainingX;
    void Start()
    {
        initialPosition = transform.position;
        remainingZ = Mathf.Abs(offsetZ);
        remainingX = Mathf.Abs(offsetX);
    }

    // Update is called once per frame
    void Update()
    {
        if (collisionDetected)
        {
            if (remainingX > 0 || remainingZ > 0)
            {
                float deltaX = speed * Time.deltaTime;
                if (deltaX > remainingX)
                    deltaX = remainingX;
                float deltaZ = speed * Time.deltaTime;
                if (deltaZ > remainingZ)
                    deltaZ = remainingZ;
                remainingX -= deltaX;
                deltaX *= offsetX > 0 ? 1 : -1;
                remainingZ -= deltaZ;
                deltaZ *= offsetZ > 0 ? 1 : -1;
                transform.Translate(deltaX, 0, deltaZ);
            }
            else
            {
                offsetZ *= -1;
                offsetX *= -1;
                remainingZ = Mathf.Abs(offsetZ);
                remainingX = Mathf.Abs(offsetX);
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            collisionDetected = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            collisionDetected = false;
        }
    }
}
