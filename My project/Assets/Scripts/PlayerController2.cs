using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class PlayerController2 : MonoBehaviour
{

public float speed;

public float rotSpeed;

public float hInput;

public float vInput;

public float jumpForce;

public Rigidbody playerRB;

    void Update()
    {
        hInput = Input.GetAxis("Horizontal");
        vInput = Input.GetAxis("Vertical");


        transform.Rotate(Vector3.up, hInput * rotSpeed * Time.deltaTime);//Move the vehicle left and right (side-to-side)
        transform.Translate(Vector3.forward * vInput * speed * Time.deltaTime);//Moves the vehicle foreward and backwards
    }
}
