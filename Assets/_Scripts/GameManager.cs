using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GameManager : MonoBehaviour
{
    public static bool gameOver;

    public InputManager inputManager;
    public ObjSpawnManager spawnedObject;
    public int numToWin;
    //panel to spawn once a player reaches the winning number of toys
    public GameObject gameOverPanel;
    //text to set according to which player won
    public Text playerWinText;

    private int _leftPlayerScore;
    private int _rightPlayerScore;

	// Use this for initialization
	void Start ()
    {
        gameOver = false;
        inputManager.gameObject.SetActive(true);
    }

    // Update is called once per frame
    void Update ()
    {
		if(gameOver)
        {
            gameOver = false;
            inputManager.gameObject.SetActive(false);
        }
	}

    public void ActivateTarget()
    {
        inputManager.ActivateTarget();
    }

    public void AddPoints(int playerNum)
    {
        if (playerNum == 0)
        {
            _leftPlayerScore++;

            if(_leftPlayerScore >= numToWin)
            {
                gameOver = true;
                playerWinText.text = "Left Player Wins!";
                gameOverPanel.SetActive(true);
                spawnedObject.gameObject.SetActive(false);
            }

        }

        else if (playerNum == 1)
        {
            _rightPlayerScore++;

            if(_rightPlayerScore >= numToWin)
            {
                gameOver = true;
                playerWinText.text = "Right Player Wins!";
                gameOverPanel.SetActive(true);
                spawnedObject.gameObject.SetActive(false);
            }
        }
    }
}
