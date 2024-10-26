using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;
    Vector3 move;
    Vector3 offset;
    [SerializeField]
    float speed = 1;
    Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        move = new Vector3();
        offset = transform.position;
       
    }

    // Update is called once per frame
    void Update()
    {
        rb.constraints = RigidbodyConstraints.FreezeRotation;
        transform.position = new Vector3(0, 3, offset.z + target.position.z-10);

    }
}
