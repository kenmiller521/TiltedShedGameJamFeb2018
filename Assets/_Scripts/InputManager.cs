﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    //bool to reference whether input is monitored
    public bool inputActive;
    //displays current target input
    public SpriteRenderer currentSymbol;
    //sprites that will be randomly chosen and set to currentSymbol to show which button to press
    public Sprite[] symbols;
    public GameManager gameManager;
    public GameObject inGameUI;
    public ObjectPointDrop opj;
    public AudioSource audioSource;
    //enum and instance of it to choose target input
    private enum TargetInput { Left, Middle, Right};
    private TargetInput _targetInput;

    private bool _leftPlayerInputActive;
    private bool _rightPlayerInputActive;

    private ButtonController buttonController;

	// Use this for initialization
	void Start ()
    {
        _leftPlayerInputActive = false;
        _rightPlayerInputActive = false;
        buttonController = inGameUI.GetComponent<ButtonController>();
        inputActive = false;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //Input is being monitored
        if (inputActive)
        {
            //Current Target is the Left Button
            if (_targetInput == TargetInput.Left)
            {
                if (_leftPlayerInputActive)
                {
                    if (Input.GetKeyDown(KeyCode.Z))
                    {
                        inputActive = false;
                        gameManager.AddPoints(0);
                        opj.SpawnSpriteToSide(0);
                        currentSymbol.sprite = null;
                        print("LEFT PLAYER WINS");
                        return;
                    }

                    else if (Input.GetKeyDown(KeyCode.X) || Input.GetKeyDown(KeyCode.C))
                    {
                        _leftPlayerInputActive = false;
                        buttonController.InputActive = false;
                        DisableLeftPlayerButtons();
                    }
                }

                if (_rightPlayerInputActive)
                {
                    if (Input.GetKeyDown(KeyCode.B))
                    {
                        inputActive = false;
                        gameManager.AddPoints(1);
                        opj.SpawnSpriteToSide(1);
                        currentSymbol.sprite = null;
                        print("RIGHT PLAYER WINS");
                        return;

                    }

                    else if (Input.GetKeyDown(KeyCode.N) || Input.GetKeyDown(KeyCode.M))
                    {
                        _rightPlayerInputActive = false;
                        buttonController.InputActive = false;
                        DisableRightPlayerButtons();
                    }
                }
            }

            else if (_targetInput == TargetInput.Middle)
            {
                if (_leftPlayerInputActive)
                {
                    if (Input.GetKeyDown(KeyCode.X))
                    {
                        inputActive = false;
                        gameManager.AddPoints(0);
                        opj.SpawnSpriteToSide(0);
                        currentSymbol.sprite = null;
                        print("LEFT PLAYER WINS");
                        return;

                    }

                    else if (Input.GetKeyDown(KeyCode.Z) || Input.GetKeyDown(KeyCode.C))
                    {
                        _leftPlayerInputActive = false;
                        buttonController.InputActive = false;
                        DisableLeftPlayerButtons();
                    }
                }

                if (_rightPlayerInputActive)
                {
                    if (Input.GetKeyDown(KeyCode.N))
                    {
                        inputActive = false;
                        gameManager.AddPoints(1);
                        opj.SpawnSpriteToSide(1);
                        currentSymbol.sprite = null;
                        print("RIGHT PLAYER WINS");
                        return;

                    }

                    else if (Input.GetKeyDown(KeyCode.B) || Input.GetKeyDown(KeyCode.M))
                    {
                        _rightPlayerInputActive = false;
                        buttonController.InputActive = false;
                        DisableRightPlayerButtons();
                    }
                }
            }

            else if (_targetInput == TargetInput.Right)
            {
                if (_leftPlayerInputActive)
                {
                    if (Input.GetKeyDown(KeyCode.C))
                    {
                        inputActive = false;
                        gameManager.AddPoints(0);
                        opj.SpawnSpriteToSide(0);
                        currentSymbol.sprite = null;
                        print("LEFT PLAYER WINS");
                        return;

                    }

                    else if (Input.GetKeyDown(KeyCode.Z) || Input.GetKeyDown(KeyCode.X))
                    {
                        _leftPlayerInputActive = false;
                        buttonController.InputActive = false;
                        DisableLeftPlayerButtons();
                    }
                }

                if (_rightPlayerInputActive)
                {
                    if (Input.GetKeyDown(KeyCode.M))
                    {
                        inputActive = false;
                        gameManager.AddPoints(1);
                        opj.SpawnSpriteToSide(1);
                        currentSymbol.sprite = null;
                        print("RIGHT PLAYER WINS");
                        return;

                    }

                    else if (Input.GetKeyDown(KeyCode.B) || Input.GetKeyDown(KeyCode.N))
                    {
                        _rightPlayerInputActive = false;
                        buttonController.InputActive = false;
                        DisableRightPlayerButtons();
                    }
                }
            }
        }
    }

    //randomly assign a symbol sprite to the targetInput object
    public void ActivateTarget()
    {
        audioSource.Play();
        int randomIndex = Random.Range(0, symbols.Length);
        currentSymbol.sprite = symbols[randomIndex];

        if (randomIndex == 0)
            _targetInput = TargetInput.Left;

        else if (randomIndex == 1)
            _targetInput = TargetInput.Middle;

        if (randomIndex == 2)
            _targetInput = TargetInput.Right;

        currentSymbol.enabled = true;

        _leftPlayerInputActive = true;
        _rightPlayerInputActive = true;
        buttonController.InputActive = true;
        EnableLeftPlayerButtons();
        EnableRightPlayerButtons();
        inputActive = true;
    }

    public void DeactivateInput()
    {
        inputActive = false;
    }

    public void ActivateInput()
    {
        inputActive = true;
    }

    private void DisableLeftPlayerButtons() {
        buttonController.zButton.color = Color.gray;
        buttonController.xButton.color = Color.gray;
        buttonController.cButton.color = Color.gray;
    }

    private void DisableRightPlayerButtons() {
        buttonController.bButton.color = Color.gray;
        buttonController.nButton.color = Color.gray;
        buttonController.mButton.color = Color.gray;
    }

    private void EnableLeftPlayerButtons() {
        buttonController.zButton.color = Color.white;
        buttonController.xButton.color = Color.white;
        buttonController.cButton.color = Color.white;
    }

    private void EnableRightPlayerButtons() {
        buttonController.bButton.color = Color.white;
        buttonController.nButton.color = Color.white;
        buttonController.mButton.color = Color.white;
    }
}
