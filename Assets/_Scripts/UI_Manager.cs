﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary>
/// A script that encapsulates all the functionality of the UI in and out of game
/// </summary>
public class UI_Manager : MonoBehaviour {

    public GameObject MainMenuCanvas;    // The main menu canvas
    public GameObject PauseMenuCanvas;   // The pause menu canvas
    public GameObject InGameCanvas;      // The in game UI

    bool Paused = false;            // Bool to determine if e are paused
    bool inGame = false;            // Determine if e are able to pause    

    // Use this for initialization
    private void Start()
    {
        PauseMenuCanvas.gameObject.SetActive(false);
    }

    // Update is called once per frame
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && inGame)
        {
            Debug.Log("PAWWWWSSEED");
            if (Paused == true)
            {
                Time.timeScale = 1.0f;
                PauseMenuCanvas.gameObject.SetActive(false);
                Paused = false;
            } 
            else if (Paused == false)
            {
                Time.timeScale = 0.0f;
                PauseMenuCanvas.gameObject.SetActive(true);
                Paused = true;
            }
        }
    }

    public void Restart() 
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

// Main Menu Functions
    public void Start_Game()
    {
        Debug.Log("START NYAOOOOWWWW");
        inGame = true;
        MainMenuCanvas.gameObject.SetActive(false);
        //SceneManager.LoadScene("");
    }

    public void Quit_Game () 
    {
        Debug.Log("NYAAAAANNN QUIT GAME");
        Application.Quit();
    }

// Pause Menu Functions
    public void Resume_Game() 
    {
        Debug.Log("RESUMEDDDD");
        PauseMenuCanvas.gameObject.SetActive(false);
        Time.timeScale = 1.0f;
    }

    public void Main_Menu() 
    {
        inGame = false;
        PauseMenuCanvas.gameObject.SetActive(false);
        MainMenuCanvas.gameObject.SetActive(true);
    }
}
