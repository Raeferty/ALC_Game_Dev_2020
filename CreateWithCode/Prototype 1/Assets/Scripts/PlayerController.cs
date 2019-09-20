using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Player control is called before the first frame update
    public float speed = 5.0f;
    public float turnSpeed = 5.0f;
    public float horizontalInput;
    public float forwardInput;

    // Update is called once per frame
    void Update()
    {
        // This code will move the vehicle forward and back, rotate it left and right.

        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput);
    }
}
