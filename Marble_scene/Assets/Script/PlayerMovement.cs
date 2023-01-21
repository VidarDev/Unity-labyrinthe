using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public int speed;
    public float jumpspeed;
    public bool isGrounded = false;
    private Rigidbody rb;

    // Appel avant la modification de frames
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Appel à chaque frame
    void Update()
    {
        float hMovement = Input.GetAxis("Horizontal");
        float vMovement = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(hMovement, 0.0f, vMovement);
        rb.AddForce(movement * speed);

        // Si le player n'est pas en l'air et que l'une des touches de saut est pressée
        if (JumpKey() && isGrounded) {
            rb.AddForce(Vector3.up * jumpspeed, ForceMode.Impulse);
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
