using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Antlr3.Runtime;
using UnityEngine;
using UnityEngine.UI;

public class PauseMenu : MonoBehaviour

{
     
    private bool paused = false;
    public GameObject pauseMenuPanel;
    public GameObject resumeButton;

    public GameObject ResumeGamePanel;
    public void UnPauseGame()
    {

    }
    // Start is called before the first frame update
    void Start()
    {
    
    }

    public void PauseGame()
    {
        paused = !paused;
        if (paused)
        {
            Time.timeScale = 0f;
            pauseMenuPanel.SetActive(true);
        }
        else
        {
            Debug.Log("play");
            Time.timeScale = 1f;
            pauseMenuPanel.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyUp(KeyCode.Escape)){
            PauseGame();
        }
    }
}
