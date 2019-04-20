using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransNoEnemyAround : FSMtransition
{
    // Use this for initialization
    public void Start()
    {
        transition = "No Enemy Around";
    }

    public override void doInTransition()
    {
        Debug.Log("Transisi No Enemy Around");
    }
}
