using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject gameObject;
    public Transform target;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        /*if (target.position.z += 10)
        {
            Vector3 spawnPoint = new Vector3(Random.Range(target.position.x - 1, target.position.x + 1), 0, Random.Range(target.position.z + 1, target.position.z + 2));
            Instantiate(gameObject, spawnPoint, Quaternion.identity);
            if (transform.position.z < target.position.z)
            {
                Destroy(gameObject);
            }
        }*/
    }
}
