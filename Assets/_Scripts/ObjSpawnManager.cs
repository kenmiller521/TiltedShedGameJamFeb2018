using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjSpawnManager : MonoBehaviour {

    public Sprite[] goodItems;
    public Sprite[] badItems;
    public GameObject spawnedObj;
    private SpriteRenderer spriteR;
    private Animator anim;
    private int goodbad;
    private int randsprite;

	void Awake () {
        spriteR = spawnedObj.GetComponent<SpriteRenderer>();
        anim = spawnedObj.GetComponent<Animator>();
        goodbad = (int)(Random.Range(1.0f, 3.9f));
        randsprite = (int)(Random.Range(1.0f, 3.9f));
        anim.SetBool(0, true);
	}

    public void DetermineObject()
    {
        if (goodbad <= 2)
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
        goodbad = (int)(Random.Range(1.0f, 2.9f));
        randsprite = (int)(Random.Range(1.0f, 3.9f));
        yield return new WaitForSeconds(1f);
    }
}
