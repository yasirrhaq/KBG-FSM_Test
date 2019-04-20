using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FSMswordman : MonoBehaviour
{
    public FSMSystem _FSMsystem;
    //public bool isAdaMusuh = false;
    public bool isEnemyNearby = false;
    public bool isMedKitNearby = false;
    public bool isBadKitNearby = false;
    //public int nyawa = 50;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        _FSMsystem.currentState.Reason(this.gameObject);
        _FSMsystem.currentState.Act(this.gameObject);

    }
}