using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransBadKitNearby : FSMtransition
{
    // Use this for initialization
    public void Start()
    {
        transition = "Bad Kit Nearby";
    }

    public override void doInTransition()
    {
        Debug.Log("Transisi Bad Kit Nearby");
    }
}
