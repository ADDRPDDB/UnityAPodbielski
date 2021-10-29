using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lab03_4 : MonoBehaviour
{
    public Camera cameraComponent;
    public Vector3 cameraOffset;
    public float movementSpeed = 5.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        cameraComponent.transform.position = transform.position + cameraOffset;
        transform.Translate(new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical")) * movementSpeed * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Przeszkoda")
        {
            Debug.Log("Trafiono na przeszkodê.");
        }
    }
}
