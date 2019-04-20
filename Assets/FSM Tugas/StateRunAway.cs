using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StateRunAway : FSMState
{
    public FSMSystem BaseFSMsystem;
    public Text result;


    public StateRunAway()
    {
        stateID = StateID.RunAway;
    }

    public override void Act(GameObject npc)
    {
        result.text = "Run Away";
    }

    public override void Reason(GameObject npc)
    {
        if (!this.GetComponent<FSMswordman>().isBadKitNearby && !this.GetComponent<FSMswordman>().isMedKitNearby)
        {
            BaseFSMsystem.PerformTransition(transitions[0]); 
        }
    }
}
