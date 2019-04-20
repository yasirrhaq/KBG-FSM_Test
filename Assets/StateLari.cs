using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StateLari : FSMState
{
    //public bool isAman = false;
    public FSMSystem BaseFSMsystem;
    public Text result;

    public StateLari()
    {
        //stateID = StateID.Lari;
    }

    public override void Act(GameObject npc)
    {
        result.text = "Lari";
    }

    public override void Reason(GameObject npc)
    {
        //if (this.GetComponent<FSMswordman>().nyawa <= 0)
        //{
        //    BaseFSMsystem.PerformTransition(transitions[1]);
        //}
        //else if (!this.GetComponent<FSMswordman>().isAdaMusuh)
        //{
        //    BaseFSMsystem.PerformTransition(transitions[0]); //choose the right transition if there are more than 1 transition
        //}
    }

}
