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
    public Text leftPlayerScoreText;
    public Text rightPlayerScoreText;

    public Animator player1Anim;
    public Animator player2Anim;
    public AudioSource meowAudioSource,hissAudioSource;

    private int _leftPlayerScore;
    private int _rightPlayerScore;

	// Use this for initialization
	void Start ()
    {
        inputManager.ActivateTarget();
        gameOver = false;

        spawnedObject.gameObject.SetActive(true);
        inputManager.GetComponent<Animator>().enabled = true;

        
    }

    // Update is called once per frame
    void Update ()
    {
	}

    public void ActivateTarget()
    {
        inputManager.ActivateTarget();
    }

    public void AddPoints(int playerNum)
    {
        if (playerNum == 0)
        {
            if(ObjSpawnManager.droppedGoodItem)
            {
                _leftPlayerScore++;
                meowAudioSource.Play();
                player1Anim.SetTrigger("IsSuccess");
            }

            else
            {
                _leftPlayerScore--;
                hissAudioSource.Play();
            }
               

            leftPlayerScoreText.text = "" + _leftPlayerScore;

            if (_leftPlayerScore >= numToWin)
            {
                gameOver = true;
                playerWinText.text = "Left Player Wins!";
                gameOverPanel.SetActive(true);
                spawnedObject.gameObject.SetActive(false);
                inputManager.GetComponent<Animator>().enabled = false;
            }

        }

        else if (playerNum == 1)
        {
            if (ObjSpawnManager.droppedGoodItem)
            {
                _rightPlayerScore++;
                meowAudioSource.Play();
                player2Anim.SetTrigger("IsSuccess");
            }

            else
            {
                _rightPlayerScore--;
                hissAudioSource.Play();
            }
               

            rightPlayerScoreText.text = "" + _rightPlayerScore;

            if (_rightPlayerScore >= numToWin)
            {
                gameOver = true;
                playerWinText.text = "Right Player Wins!";
                gameOverPanel.SetActive(true);
                spawnedObject.gameObject.SetActive(false);
                inputManager.GetComponent<Animator>().enabled = false;
            }
        }
    }
}
