using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lab05_2 : MonoBehaviour
{
    public Vector3 openOffset;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            transform.Translate(openOffset);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            transform.Translate(-openOffset);
        }
    }
}
