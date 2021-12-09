using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lab05_3 : MonoBehaviour
{
    public List<Vector3> Points;
    public float speed = 10.0f;
    public int currentPoint;
    public bool forward = true;
    // Start is called before the first frame update
    void Start()
    {
        if (Points.Count > 0)
            currentPoint = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (Points.Count > 0)
        {
            if (transform.position == Points[currentPoint])
                if (currentPoint < Points.Count - 1 && forward)
                    currentPoint++;
                else if (currentPoint > 0 && !forward)
                    currentPoint--;
                else
                    forward = !forward;
            transform.position = Vector3.MoveTowards(transform.position, Points[currentPoint], speed * Time.deltaTime);
        }
           
    }
}
