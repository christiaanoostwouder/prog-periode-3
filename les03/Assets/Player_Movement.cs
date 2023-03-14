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
        rb.velocity = rb.transform.forward * move;      

        Debug.Log(rb.velocity);

        float rot = Input.GetAxis("Horizontal") * rotSpeed * Time.deltaTime;
        rb.transform.Rotate(new Vector3(0, rot, 0));
        
    }
}
