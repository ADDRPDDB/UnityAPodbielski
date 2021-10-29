using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lab03_5 : MonoBehaviour
{
    public GameObject prefab;
    List<GameObject> spawnedObjects = new List<GameObject>();
    // Start is called before the first frame update
    void Start()
    {
        Bounds tempBounds = new Bounds();
        tempBounds.size = prefab.GetComponent<BoxCollider>().size * 2;
        for (int i = 0; i < 10; i++)
        {
            bool flag = true;
            Vector3 newPos = new Vector3();
            while (flag)
            {
                flag = false;
                newPos.Set(Random.Range(-5, 5), 0, Random.Range(-5, 5));
                foreach (GameObject obj in spawnedObjects)
                {
                    tempBounds.center = obj.transform.position;
                    if (tempBounds.Contains(newPos))
                        flag = true;
                }
            }
            Instantiate(prefab, new Vector3(Random.Range(-5, 5), 0, Random.Range(-5, 5)), Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
