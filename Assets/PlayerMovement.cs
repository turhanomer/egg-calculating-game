using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5.0f; // Hareket hýzý

    void Update()
    {
        // Sað ve sol hareketi için input deðerini al
        float move = Input.GetAxis("Horizontal");

        // Hareket vektörünü oluþtur
        transform.Translate(transform.right*move*speed*Time.deltaTime);

    }
}
