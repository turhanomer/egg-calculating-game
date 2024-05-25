using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5.0f; // Hareket h�z�

    void Update()
    {
        // Sa� ve sol hareketi i�in input de�erini al
        float move = Input.GetAxis("Horizontal");

        // Hareket vekt�r�n� olu�tur
        transform.Translate(transform.right*move*speed*Time.deltaTime);

    }
}
