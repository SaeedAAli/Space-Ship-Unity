using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float FireForce = 100f;

    public int damageValue = 10;

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Rigidbody2D>().AddRelativeForce(Vector2.up * FireForce);
        // After 2 seconds, destroy the bullet (just in case)
        Destroy(gameObject, 2f);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Asteriod"))
        {
            // Deal damage to the asteroid
            collision.gameObject.GetComponent<Asteroid>().KillAsteroid(damageValue);
        }
            //else if (collision.gameObject.CompareTag("Enemy"))
            // Always destroy the bullet last
        {
            Destroy(gameObject);
        }
    
    }

}