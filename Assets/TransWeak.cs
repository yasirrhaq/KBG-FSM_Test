using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransWeak : FSMtransition {

    // Use this for initialization
    public void Start()
    {
        transition = "Weak";
    }

    public override void doInTransition()
    {
        Debug.Log("transisi weak");
    }
}
