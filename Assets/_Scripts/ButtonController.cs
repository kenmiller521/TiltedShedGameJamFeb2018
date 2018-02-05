using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonController : MonoBehaviour {

    // Button References
    public Image zButton, xButton, cButton;
    public Image bButton, nButton, mButton;

    public bool InputActive = true;     // Can we press the buttons?

    public Animator player1Anim;
    public Animator player2Anim;

	private void Update () {
        // In Game Buttons
        bool player1Swipe = false;
        bool player2Swipe = false;

        if (InputActive) { 
            if (Input.GetKeyDown(KeyCode.Z)) 
            {
                Debug.Log("Z");
                zButton.color = Color.gray;
                player1Swipe = true;
            } else if (Input.GetKeyDown(KeyCode.X)) 
            {
                Debug.Log("X");
                xButton.color = Color.gray;
                player1Swipe = true;
            } else if (Input.GetKeyDown(KeyCode.C)) 
            { 
                Debug.Log("C");
                cButton.color = Color.gray;
                player1Swipe = true;
            } else if (Input.GetKeyDown(KeyCode.B)) 
            {
                Debug.Log("B");
                bButton.color = Color.gray;
                player2Swipe = true;
            } else if (Input.GetKeyDown(KeyCode.N)) 
            { 
                Debug.Log("N");
                nButton.color = Color.gray;
                player2Swipe = true;
            } else if (Input.GetKeyDown(KeyCode.M)) 
            {
                Debug.Log("M");
                mButton.color = Color.gray;
                player2Swipe = true;
            }

            if(player1Swipe)
            {
                player1Anim.SetTrigger("Swiped");
            }
            if(player2Swipe)
            {
                player2Anim.SetTrigger("Swiped");
            }

            if (Input.GetKeyUp(KeyCode.Z)) 
            {
                zButton.color = Color.white;
            } else if (Input.GetKeyUp(KeyCode.X)) 
            {
                xButton.color = Color.white;
            } else if (Input.GetKeyUp(KeyCode.C)) 
            { 
                cButton.color = Color.white;
            } else if (Input.GetKeyUp(KeyCode.B)) 
            {
                bButton.color = Color.white;
            } else if (Input.GetKeyUp(KeyCode.N)) 
            { 
                nButton.color = Color.white;
            } else if (Input.GetKeyUp(KeyCode.M)) 
            {
                mButton.color = Color.white;
            }
        }
	}
}
