using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PillarRotation : MonoBehaviour
{
    private int speed = 110;
    public bool reverse_rotation = false;
    // Executé à chaque frame
    void Update()
    {
        // A chaque frame l'axe x change selon la formule speed * intervale entre la dernière frame et l'actuelle
        if(reverse_rotation == true)
        {
            speed = 150;
            transform.Rotate(-speed * Time.deltaTime, 0, 0);
        }
        else
        {
            transform.Rotate(speed * Time.deltaTime, 0, 0);
        }
    }
}