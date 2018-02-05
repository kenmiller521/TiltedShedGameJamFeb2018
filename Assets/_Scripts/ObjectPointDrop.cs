using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPointDrop : MonoBehaviour {

    public GameObject item;
    public GameObject newPrefab;

    public Transform left;
    public Transform right;

    private SpriteRenderer spriteR;
	// Use this for initialization
	void Awake () {
        spriteR = item.GetComponent<SpriteRenderer>();
    }
	
    public void SpawnSpriteToSide(int playernum)
    {
        if (playernum == 0)
        {
            newPrefab = Instantiate(newPrefab, left);
            spriteRNew.sprite = spriteR.sprite;
        }
        else
        {
            newPrefab = Instantiate(newPrefab, right);
            spriteRNew.sprite = spriteR.sprite;
        }
    }
}
