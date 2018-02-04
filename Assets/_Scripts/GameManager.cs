using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GameManager : MonoBehaviour
{
    public static bool gameOver;

    public InputManager inputManager;
    public int numToWin;
    //panel to spawn once a player reaches the winning number of toys
    public GameObject gameOverPanel;
    //text to set according to which player won
    public Text playerWinText;

    public float spawnTime;

    private float _spawnTimer;
    private int _leftPlayerScore;
    private int _rightPlayerScore;

	// Use this for initialization
	void Start ()
    {
        inputManager.ActivateTarget();
        gameOver = false;

        _spawnTimer = spawnTime;

        inputManager.ActivateTarget();
    }
	
	// Update is called once per frame
	void Update ()
    {
		if(!gameOver)
        {
            _spawnTimer -= Time.deltaTime;

            if(_spawnTimer <= 0)
            {
                _spawnTimer = spawnTime;
                inputManager.ActivateTarget();                
            }
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
            }
        }
    }
}
