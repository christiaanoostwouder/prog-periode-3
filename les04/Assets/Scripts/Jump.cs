using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour

{
    private Rigidbody rb;
    public float force = 20f;

    public bool onFloor = false;

    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "floor")
        {
            onFloor = true;
        }
    }

    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.Space) && onFloor == true)
            {
            rb.AddForce(Vector3.up * force);
            onFloor = false;
        }
    }
}