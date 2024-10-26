using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Move : MonoBehaviour
{
    Collider collider;
    Vector3 move;
    [SerializeField]
    float speed = 1;
    Rigidbody rb;
    bool inverted = false;
    public GameObject obstacle;

    public GameObject plane;

    int pos = 1;
    // Start is called before the first frame update
    void Start()
    {
        //InvokeRepeating("Spawn", 2.0f, 3.0f);
        rb = GetComponent<Rigidbody>();
        move = new Vector3();
        collider = GetComponent<Collider>();
    }
    public void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Collide");
        if (collision.collider.gameObject.tag == ("Hole"))
        {
            collider.enabled = false;
        }
    }
    // Update is called once per frame
    void Update()
    {
        Spawn();
        move = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 10);

        //rb.AddForce(Vector3.forward * 1);

        if (move.x > 0)
        {
            rb.AddForce(Vector3.right);
        }

        else if (move.x < 0)
        {
            rb.AddForce(Vector3.left);
        }

        if (Input.GetKeyDown(KeyCode.UpArrow) && !inverted)
        {
            rb.AddForce(Vector3.up * 5, ForceMode.Impulse);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("gravity");
            Physics.gravity = Physics.gravity*-1;
            //rb.AddForce(Physics.gravity, ForceMode.Impulse);
        }

        if (inverted)
        {
            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                Debug.Log("inverted2");
                rb.AddForce(Vector3.up * -5, ForceMode.Impulse);
        }
            
        }
    }
    void FixedUpdate()
    {
        rb.AddForce(move);
    }

    public void Spawn()
    {
        if (transform.position.z >= 110*pos )
        {
            //pos++;
            Vector3 spawnPoint = new Vector3(Random.Range(-10, 10), 0f, transform.position.z + 200);
            Instantiate(plane, spawnPoint, Quaternion.identity);
            Vector3 spawnPoint2 = new Vector3(Random.Range(-4, 4), 0f, Random.Range(transform.position.z + 40, transform.position.z + 50));
            Instantiate(obstacle, spawnPoint2, Quaternion.identity);
            pos++;
            Debug.Log(pos);
        }

  
    }

}

