using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Movement : MonoBehaviour
{
    [SerializeField]private float speed = 500f;
    [SerializeField]private float rotSpeed = 70f;
    private Rigidbody rb;
    

   
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
    }
    

   
    void Update()
    {
        float move = Time.deltaTime * speed * Input.GetAxis("Vertical");
        //rb.velocity = rb.transform.forward * move;
        Vector3 lastVel = rb.velocity;
        Vector3 newVel = rb.transform.forward * move;
        newVel.y = lastVel.y;
        rb.velocity = newVel;      

        //Debug.Log(rb.velocity);

        float rot = Input.GetAxis("Horizontal") * rotSpeed * Time.deltaTime;
        rb.transform.Rotate(new Vector3(0, rot, 0));

        
        
    }

    
}

