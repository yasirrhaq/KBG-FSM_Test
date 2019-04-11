using UnityEngine;

public enum StateID
{
    NullStateID = 0, // Use this ID to represent a non-existing State in your system	
    Patrol = 1,
    Lari = 2,
    Serang = 3,
    Death = 4,
}

public abstract class FSMState : MonoBehaviour
{
    //public Dictionary<Transition, StateID> map = new Dictionary<Transition, StateID>();
    public FSMtransition[] transitions;
    protected StateID stateID;
    public StateID ID { get { return stateID; } }
    /// <summary>
    /// This method returns the new state the FSM should be if
    ///    this state receives a transition and 
    /// </summary>
    public StateID GetTargetState(FSMtransition trans)
    {
        foreach (FSMtransition T in transitions)
        {
            if (T.transition.Equals(trans.transition))
            {
                T.doInTransition();
                return T.targetStateID;
            }
        }
        return StateID.NullStateID;

    }

    /// <summary>
    /// This method is used to set up the State condition before entering it.
    /// It is called automatically by the FSMSystem class before assigning it
    /// to the current state.
    /// </summary>
    public virtual void DoBeforeEntering() { }

    /// <summary>
    /// This method is used to make anything necessary, as reseting variables
    /// before the FSMSystem changes to another one. It is called automatically
    /// by the FSMSystem before changing to a new state.
    /// </summary>
    public virtual void DoBeforeLeaving() { }

    /// <summary>
    /// This method decides if the state should transition to another on its list
    /// NPC is a reference to the object that is controlled by this class
    /// </summary>
    public abstract void Reason(GameObject npc);

    /// <summary>
    /// This method controls the behavior of the NPC in the game World.
    /// Every action, movement or communication the NPC does should be placed here
    /// NPC is a reference to the object that is controlled by this class
    /// </summary>
    public abstract void Act(GameObject npc);

} // class FSMState
