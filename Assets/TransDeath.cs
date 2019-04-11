using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransDeath : FSMtransition {

    // Use this for initialization
    public void Start()
    {
        transition = "Death";
    }

    public override void doInTransition()
    {
        Debug.Log("transisi death");
    }
}
