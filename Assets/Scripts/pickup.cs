    using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickup : MonoBehaviour
{
    private GameManager gameManager;

    // Start is called before the first frame update
    void Start()
    {
      gameManager = FindAnyObjectByType<GameManager>();

    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            GetComponent<SpriteRenderer>().enabled = false;
            GetComponent<Collider2D>().enabled = false;
            gameManager.AlterScore(1);
            Destroy(gameObject, 2f);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
     
