using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetermineObjectAnimationEvent : MonoBehaviour {

	void DetermineObject()
    {
        GetComponentInParent<ObjSpawnManager>().DetermineObject();
    }
}
