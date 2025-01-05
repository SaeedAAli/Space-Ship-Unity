using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Asteroid : MonoBehaviour
{

    public pickup pickupPrefab;

    Rigidbody2D rb2d;
    GameManager gameManager;

    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();

        float randomX = Random.Range(-5, 5),
            randomY = Random.Range(-5, 5);

        Vector2 randomDirection = new Vector2(randomX, randomY);
        rb2d.AddForce(randomDirection, ForceMode2D.Impulse);
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();

    }



    public void KillAsteroid(int damageValue)
    {
        gameManager.AlterScore(1);
        Instantiate(pickupPrefab, transform.position, transform.rotation);
        Destroy(this.gameObject);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            
            collision.gameObject.GetComponent<Player>().receiveDamage(1);
        }
    }


    // Update is called once per frame
    void Update()
    {     
    }
}



