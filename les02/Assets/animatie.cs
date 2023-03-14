using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animatie : MonoBehaviour
{
    Animator m_Animator;
    // Start is called before the first frame update
    void Start()
    {
        m_Animator = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            m_Animator.ResetTrigger("Crouch");
            m_Animator.SetTrigger("Jump");
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            m_Animator.ResetTrigger("Jump");
            m_Animator.SetTrigger("Crouch");
        }
    }
}
