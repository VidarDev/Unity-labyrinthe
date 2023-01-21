using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float speed = 2f;
    private Rigidbody rigid;

    private void Start()
    {
        rigid = gameObject.GetComponent<Rigidbody>();
    }

    private void Update()
    { 
        if(Input.GetAxis("Horizontal") > 0)
        { 
            rigid.AddForce(Vector3.forward * speed); 
        }
        else if (Input.GetAxis("Horizontal") < 0) 
        {
            rigid.AddForce(-Vector3.forward * speed);
        } 
        if (Input.GetAxis("Vertical") > 0)
        {
            rigid.AddForce(-Vector3.right * speed);
        }
        else if (Input.GetAxis("Vertical") < 0) 
        {
            rigid.AddForce(Vector3.right * speed);
        } 
    }
}
