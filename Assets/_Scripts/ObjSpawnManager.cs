using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjSpawnManager : MonoBehaviour
{
    public static bool droppedGoodItem;
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
        goodbad = Random.Range(0, 4);
        randsprite = Random.Range(0, 3);
        anim.SetBool(0, true);
	}

    public void DetermineObject()
    {
        if (goodbad <= 1)
        {
            droppedGoodItem = true;
            switch (randsprite)
            {
                case 0:
                    spriteR.sprite = goodItems[0];
                    break;
                case 1:
                    spriteR.sprite = goodItems[1];
                    break;
                case 2:
                    spriteR.sprite = goodItems[2];
                    break;
            }
        }
        else
        {
            droppedGoodItem = false;
            switch (randsprite)
            {
                case 0:
                    spriteR.sprite = badItems[0];
                    break;
                case 1:
                    spriteR.sprite = badItems[1];
                    break;
                case 2:
                    spriteR.sprite = badItems[2];
                    break;
            }
        }
        StartCoroutine(SpawnDelay());
    }

    IEnumerator SpawnDelay()
    {
        goodbad = Random.Range(0, 4);
        randsprite = Random.Range(0, 3);
        yield return new WaitForSeconds(1f);
    }
}
