using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransNoItemAround : FSMtransition
{
    // Use this for initialization
    public void Start()
    {
        transition = "No Item Around";
    }

    public override void doInTransition()
    {
        Debug.Log("Transisi No Item Around");
    }
}
