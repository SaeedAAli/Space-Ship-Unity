using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using TMPro;
using System;
using UnityEngine.SceneManagement;
using Unity.VisualScripting.Antlr3.Runtime;

public class Player : MonoBehaviour
{
    public int maxHealth = 10;

    public int health;

    private GameManager gameManager;

    public int TakeDamage = 1;

    public GameObject DeathScreen;

    public GameObject RestartButton;

    public GameObject ExitButton;

    //Start is called before the first frame update
    void Start()
    {
        health = maxHealth;
        gameManager = FindObjectOfType<GameManager>();
        gameManager.UpdatePlayerHealthUI(health);

    }

    private bool invunerable = false;

    IEnumerator Invunerable()
    {
        invunerable = true;

        yield return new WaitForSeconds(2.0f);

        invunerable = false;

        StartCoroutine(Invunerable());
    }


    public void receiveDamage(int damage)
    {

        health -= damage;
        gameManager.UpdatePlayerHealthUI(health);
        if (health <= 0)
        {
            endgame();
            Destroy(gameObject);

        }
    }

    public void endgame()
    {
        Time.timeScale = 0f;
        DeathScreen.SetActive(true);
    }
    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            collision.gameObject.GetComponent<Player>();

        }
    }
}



