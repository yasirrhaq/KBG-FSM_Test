using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransSawEnemy :FSMtransition {

    // Use this for initialization
    public void Start()
    {
        transition = "SawEnemy";
    }

    public override void doInTransition()
    {
        Debug.Log("transisi Saw Enemy");
    }
}
