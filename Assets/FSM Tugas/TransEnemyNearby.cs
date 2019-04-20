using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransEnemyNearby : FSMtransition
{
    // Use this for initialization
    public void Start()
    {
        transition = "Enemy Nearby";
    }

    public override void doInTransition()
    {
        Debug.Log("Transisi Enemy Nearby");
    }
}
