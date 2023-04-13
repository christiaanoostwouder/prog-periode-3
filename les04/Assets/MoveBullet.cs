using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBullet : MonoBehaviour
{
    private Rigidbody rb;
    public float speed = 500f;
    
    void Start()
    {
        
    }

     void FixedUpdate()
    {
        Rigidbody rb = GetComponent<Rigidbody>();
        rb.velocity = rb.transform.forward * speed * Time.fixedDeltaTime;
    }  
    
    
}
