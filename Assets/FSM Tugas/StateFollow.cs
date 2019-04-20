using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StateFollow : FSMState
{

    public FSMSystem BaseFSMsystem;
    public Text result;


    public StateFollow()
    {
        stateID = StateID.Follow;
    }

    public override void Act(GameObject npc)
    {
        result.text = "Follow";
    }

    public override void Reason(GameObject npc)
    {
        if (this.GetComponent<FSMswordman>().isEnemyNearby)
        {
            BaseFSMsystem.PerformTransition(transitions[0]); //choose the right transition if there are more than 1 transition
        }
        if (this.GetComponent<FSMswordman>().isMedKitNearby)
        {
            BaseFSMsystem.PerformTransition(transitions[1]); //choose the right transition if there are more than 1 transition
        }
        if (this.GetComponent<FSMswordman>().isBadKitNearby)
        {
            BaseFSMsystem.PerformTransition(transitions[2]); //choose the right transition if there are more than 1 transition
        }
    }
}