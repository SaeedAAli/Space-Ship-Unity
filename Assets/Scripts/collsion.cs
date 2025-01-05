using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class collision : MonoBehaviour
{

    float Timer;
    bool Collided;

    // Start is called before the first frame update
    void Start()
    {
        Timer = 0;
        Collided = false;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            gameObject.GetComponent<Renderer>().material.color = Color.red;
            Collided = true;
        }
    }

    void ChangeColour()
    {
        gameObject.GetComponent<Renderer>().material.color = Color.yellow;
    }


    // Update is called once per frame
    void Update()
    {
        if (Collided)
        {
            Timer += Time.deltaTime;
        }

        if (Timer >= 1.0f)
        {
            ChangeColour();
            Collided = false;
            Timer = 0;
        }
    }
}
