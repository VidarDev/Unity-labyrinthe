using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    private float vitesse = 8f;

    private Vector3 deplacement = Vector3.zero;
    
    void FixedUpdate()
    {
        if ( Input.GetKey(KeyCode.UpArrow))
        {
            deplacement = Vector3.forward;
        }
        
        if ( Input.GetKey(KeyCode.DownArrow))
        {
            deplacement = Vector3.back;
        }
//         if ( Input.GetKey(KeyCode.LeftArrow))
//         {
//             deplacement = Vector3.zero;
//             transform.Rotate(Vector3.up * -vitesse * 5 * Time.fixedDeltaTime);
//         }
//        if ( Input.GetKey(KeyCode.RightArrow))
//        {
//            deplacement = Vector3.zero;
//            transform.Rotate(Vector3.up * vitesse * 5 * Time.fixedDeltaTime);
//        }
        transform.Translate(deplacement * vitesse * Time.fixedDeltaTime); 
        deplacement = Vector3.zero;
    }
}
