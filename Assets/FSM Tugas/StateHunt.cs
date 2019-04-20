using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StateHunt : FSMState
{
    //public bool isAdaMusuh= false;
    public FSMSystem BaseFSMsystem;
    public Text result;


    public StateHunt()
    {
        stateID = StateID.Hunt;
    }

    public override void Act(GameObject npc)
    {
        result.text = "Hunt";
    }

    public override void Reason(GameObject npc)
    {
        if (this.GetComponent<FSMswordman>().isMedKitNearby)
        {
            BaseFSMsystem.PerformTransition(transitions[0]); 
        }
        if (this.GetComponent<FSMswordman>().isBadKitNearby)
        {
            BaseFSMsystem.PerformTransition(transitions[1]); 
        }
        if (!this.GetComponent<FSMswordman>().isEnemyNearby)
        {
            BaseFSMsystem.PerformTransition(transitions[2]);
        }
    }
}
