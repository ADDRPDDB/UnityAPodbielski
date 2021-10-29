using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skrzynia : MonoBehaviour
{
    public float force = 5.0f;
    // Start is called before the first frame update
    void Start()
    {
        Rigidbody rb = GetComponent<Rigidbody>();
        rb.AddForce(0, 0, force, ForceMode.Impulse);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
