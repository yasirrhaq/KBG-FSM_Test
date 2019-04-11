using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FSMtransition : MonoBehaviour {

    public StateID targetStateID;
    public string transition;

    public virtual void doInTransition()
    {
        //override this with everything do in transition
    }
    
}
