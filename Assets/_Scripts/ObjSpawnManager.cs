using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjSpawnManager : MonoBehaviour {

    public Sprite[] goodItems;
    public Sprite[] badItems;
    public GameObject spawnedObj;
    private SpriteRenderer spriteR;

    private int goodbad;
    private int randsprite;
	void Awake () {
        spriteR = spawnedObj.GetComponent<SpriteRenderer>();
        goodbad = (int)(Random.Range(1.0f, 2.9f));
        randsprite = (int)(Random.Range(1.0f, 6.9f));
	}
	
	void FixedUpdate () {
        goodbad = (int)(Random.Range(1.0f, 2.9f));
        randsprite =(int)(Random.Range(1.0f, 3.9f));
        DetermineObject();
	}
    void DetermineObject()
    {
        if (goodbad == 1)
        {
            switch (randsprite)
            {
                case 1:
                    spriteR.sprite = goodItems[0];
                    break;
                case 2:
                    spriteR.sprite = goodItems[1];
                    break;
                case 3:
                    spriteR.sprite = goodItems[2];
                    break;
            }
        }
        else
            switch(randsprite)
            {
                case 1:
                    spriteR.sprite = badItems[0];
                    break;
                case 2:
                    spriteR.sprite = badItems[1];
                    break;
                case 3:
                    spriteR.sprite = badItems[2];
                    break;
            }
        StartCoroutine(SpawnDelay());
    }
    IEnumerator SpawnDelay()
    {
        yield return new WaitForSeconds(1f);
    }
}
