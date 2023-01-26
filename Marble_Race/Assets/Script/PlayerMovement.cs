using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] GameObject player;
    public GameObject timer;
    public float speed = 5f;
    private float jumpspeed = 5;
    private bool isGrounded = false;
    private Rigidbody rigid;

    // Appel avant la modification de frames
    void Start()
    {
        rigid = gameObject.GetComponent<Rigidbody>();
    }

    // Appel à chaque frame
    private void Update()
    { 
        if(Input.anyKey) {
            timer.SetActive(true);
        }
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
        if (JumpKey() && isGrounded) {
            rigid.AddForce(Vector3.up * jumpspeed, ForceMode.Impulse);
        }
    }

    // Liste des touches permettant le saut
    private bool JumpKey()
    {
        return (Input.GetKeyDown(KeyCode.Space));
    }

    // Est appelé une fois par frame pour chaque collider ou rigidbody touchant un autre
    void OnCollisionStay(Collision collisionInfo)
    {
        isGrounded = true;
    }

    // Inverse de OnCollisionStay, lorsqu'il n'y a plus contact
    void OnCollisionExit(Collision collisionInfo)
    {
        isGrounded = false;
    }
}