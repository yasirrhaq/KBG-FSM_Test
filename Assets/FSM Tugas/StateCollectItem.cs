using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StateCollectItem : FSMState
{
    public FSMSystem BaseFSMsystem;
    public Text result;


    public StateCollectItem()
    {
        stateID = StateID.CollectItem;
    }

    public override void Act(GameObject npc)
    {
        result.text = "Collect Item";
    }

    public override void Reason(GameObject npc)
    {
        if (!this.GetComponent<FSMswordman>().isMedKitNearby && !this.GetComponent<FSMswordman>().isBadKitNearby)
        { 
            BaseFSMsystem.PerformTransition(transitions[0]); //choose the right transition if there are more than 1 transition
        }
    }
}
