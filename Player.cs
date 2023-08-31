using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private float speed = 5.5f; //Charecter speed
    private float jumpForce = 3f; //Charecter jumpForce
    private float MouseH = 2.0f; //Mouse horizontal speed
    private float MouseV = 2.0f; //Mouse vertical speed

    private float yaw = 0.0f;
    private float pitch = 0.0f;

    private Rigidbody rg;

    void Start()
    {
        rg = GetComponent<Rigidbody>();
        Cursor.lockState = CursorLockMode.Locked; //Lock cursor
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward * speed * Time.deltaTime); //Forward move
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.back * speed * Time.deltaTime); //Back move
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * speed * Time.deltaTime); //Left move
        }


        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * speed * Time.deltaTime); //Right move
        }


        
        yaw += MouseH * Input.GetAxis("Mouse X");
        pitch -= MouseV * Input.GetAxis("Mouse Y");

        transform.eulerAngles = new Vector3(pitch, yaw, 0.0f);

    }
}



