using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jumpingcylinder : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput =Input.GetAxis("Horizontal");
        float moveSpeed = 10;
        float verticalInput = Input.GetAxis("Vertical");
        Debug.Log(horizontalInput);
        transform.Translate(new Vector3(horizontalInput, verticalInput, 0) * moveSpeed * Time.deltaTime);

    }
}
