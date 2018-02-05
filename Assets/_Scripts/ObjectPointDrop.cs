using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPointDrop : MonoBehaviour {

    public GameObject item;
    public GameObject newPrefab;

    public Transform left;
    public Transform right;

    private SpriteRenderer spriteR;
    private SpriteRenderer spriteRNew;
	// Use this for initialization
	void Awake () {
        spriteR = item.GetComponent<SpriteRenderer>();
        spriteRNew = newPrefab.GetComponent<SpriteRenderer>();
    }
	
    public void SpawnSpriteToSide(int playernum)
    {
        GameObject newItem;
        if (playernum == 0)
        {
            newItem = Instantiate(newPrefab, left.position, newPrefab.transform.rotation);
            newItem.GetComponent<SpriteRenderer>().sprite = spriteR.sprite;
        }
        else
        {
            newItem = Instantiate(newPrefab, right.position, newPrefab.transform.rotation);
            newItem.GetComponent<SpriteRenderer>().sprite = spriteR.sprite;
        }

        newItem.AddComponent<PolygonCollider2D>();
    }
}
