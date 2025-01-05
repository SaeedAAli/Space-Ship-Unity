using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.Runtime.CompilerServices;

public class GameManager : MonoBehaviour
{
    public TextMeshProUGUI HealthText;

    public TextMeshProUGUI ScoreText;

    private int Score = 0;

    public void UpdatePlayerHealthUI(int health)
    {

        if (HealthText != null)
        {
            Debug.Log(health);
            HealthText.text = "Health " + health.ToString();

        }
    }


    private void UpdatePlayerScoreUI()
    {
        if (ScoreText != null)
        {
            ScoreText.text = "Score " + Score.ToString();
        }
    }

    public void scorePickup(int scorepickup)
    { 
        Score = scorepickup;
    }
    


    public void AlterScore(int newScore)
    {
        Score += newScore;
    }

    public void Update()
    {
        UpdatePlayerScoreUI();

    }
}



