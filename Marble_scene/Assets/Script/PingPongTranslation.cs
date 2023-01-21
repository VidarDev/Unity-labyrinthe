using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PingPongTranslation : MonoBehaviour
{
    /*
     * Nécessite un rigidbody sur l'élément en mouvement et un collider avec les options "convex" et "is trigger".
     * Les éléments de collision (murs) nécessitent un collider avec l'option "convex".
     * https://docs.unity3d.com/ScriptReference/Collider.OnTriggerEnter.html
     * Nécessite FixedUpdate() et non Update() vis à vis de la fréquence de calcul des collisions.
     */

    private Rigidbody rb;
    public int speed;
    public bool direction = true;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        if (direction == true) {
            //transform.Translate(0, 0, 5 * Time.deltaTime);
            transform.Translate(Vector3.forward * Time.deltaTime * speed);
        } else {
            transform.Translate(Vector3.back * Time.deltaTime * speed);
        }
    }

    // Inverse la direction de translation lors de la collision
    private void OnTriggerEnter(Collider other)
    {
        direction = !direction;
    }
}
