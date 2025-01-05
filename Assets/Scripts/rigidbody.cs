using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rigidbody : MonoBehaviour
{
    private float AddTorque = 1.0f;
    private float torqueValue = 1.0f;
    private float forceValue = 1.0f;
    private float AddForce = 1.0f;



    Rigidbody2D rb2d;
    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    
}

// Update is called once per frame
void Update()
    {
        rb2d.AddTorque(5f);
        rb2d.AddRelativeForce(Vector2.up);
        rb2d.AddRelativeForce(Vector2.down);


    }
}
