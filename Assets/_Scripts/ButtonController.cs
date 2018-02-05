using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonController : MonoBehaviour {

    // Button References
    public Image zButton, xButton, cButton;
    public Image bButton, nButton, mButton;

    public bool InputActive = true;     // Can we press the buttons?

	private void Update () {
		// In Game Buttons
        if (InputActive) { 
            if (Input.GetKeyDown(KeyCode.Z)) 
            {
                Debug.Log("Z");
                zButton.color = Color.gray;
            } else if (Input.GetKeyDown(KeyCode.X)) 
            {
                Debug.Log("X");
                xButton.color = Color.gray;
            } else if (Input.GetKeyDown(KeyCode.C)) 
            { 
                Debug.Log("C");
                cButton.color = Color.gray;
            } else if (Input.GetKeyDown(KeyCode.B)) 
            {
                Debug.Log("B");
                bButton.color = Color.gray;
            } else if (Input.GetKeyDown(KeyCode.N)) 
            { 
                Debug.Log("N");
                nButton.color = Color.gray;
            } else if (Input.GetKeyDown(KeyCode.M)) 
            {
                Debug.Log("M");
                mButton.color = Color.gray;
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
