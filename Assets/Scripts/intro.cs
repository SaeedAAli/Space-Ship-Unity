using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class intro : MonoBehaviour
{
    public float movementSpeed = 1.0f;
    public Vector2 Movement = Vector2.left;
    public Vector3 direction = Vector3.right;
    public float rotationSpeed = 1.0f;
    public Vector2 thrustvalue = Vector2.up;
    public float TorqueValue = 1.0f;

    // Start is called before the first frame update
    void Start()
    {
        
   
    }

    // Update is called once per frame
    void Update()
    {
        {
            float verticalInput = Input.GetAxis("Vertical");
            float horizontalInput = Input.GetAxis("Horizontal");

            gameObject.transform.Translate(((Vector2.up * verticalInput) * movementSpeed) * Time.deltaTime);
            gameObject.transform.Rotate(((new Vector3(0, 0, 1f) * -horizontalInput) * movementSpeed) * Time.deltaTime);

 

        }
    }
}
     
