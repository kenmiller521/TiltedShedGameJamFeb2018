using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    [SerializeField] int points;

    public int Points
    {
        get
        {
            return points;
        }
    }

    public void AddPoints()
    {

    }
}