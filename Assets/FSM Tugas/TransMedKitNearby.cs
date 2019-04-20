using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransMedKitNearby : FSMtransition
{
    // Use this for initialization
    public void Start()
    {
        transition = "Med Kit Nearby";
    }

    public override void doInTransition()
    {
        Debug.Log("Transisi Med Kit Nearby");
    }
}
