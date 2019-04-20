using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StatePatrol : FSMState
{
    //public bool isAdaMusuh= false;
    public FSMSystem BaseFSMsystem;
    public Text result;
    

    public StatePatrol()
    {
        //stateID = StateID.Patrol;
    }

    public override void Act( GameObject npc)
    {
        result.text = "Patroli";
    }

    public override void Reason( GameObject npc)
    {
        //if (this.GetComponent<FSMswordman>().nyawa <= 0)
        //{
        //    BaseFSMsystem.PerformTransition(transitions[1]);
        //}
        //else   if (this.GetComponent<FSMswordman>().isAdaMusuh)
        //{
        //    BaseFSMsystem.PerformTransition(transitions[0]); //choose the right transition if there are more than 1 transition
        //}
    }


}
