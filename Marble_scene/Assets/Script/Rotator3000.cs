using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator3000 : MonoBehaviour
{
    public int speed = 3000;
    // Executé à chaque frame
    void Update()
    {
        // A chaque frame l'axe x change selon la formule speed * intervale entre la dernière frame et l'actuelle
        transform.Rotate(speed * Time.deltaTime, 0, 0);
    }
}
