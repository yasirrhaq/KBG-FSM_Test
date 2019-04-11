using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StateDeath : FSMState
{
    //public bool isAdaMusuh= false;
    public FSMSystem BaseFSMsystem;
    public Text result;
    

    public StateDeath()
    {
        stateID = StateID.Death;
    }

    public override void Act( GameObject npc)
    {
        result.text = "You Died";
    }

    public override void Reason( GameObject npc)
    {
        if (this.GetComponent<FSMswordman>().nyawa<=0)
        {
            Destroy(this.gameObject, 2); //choose the right transition if there are more than 1 transition
        }
    }


}
