using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceshipRB : MonoBehaviour
{
    public float TorqueValue = 1.0f;
    public float ThrustValue = 8.0f;

    Rigidbody2D rb2d;

    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float verticalInput = Input.GetAxis("Vertical");
        float horizontalInput = Input.GetAxis("Horizontal");
        rb2d.AddRelativeForce((Vector2.up * verticalInput) * ThrustValue);
        rb2d.AddTorque(TorqueValue * -horizontalInput);
    }
}   