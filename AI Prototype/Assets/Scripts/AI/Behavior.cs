using UnityEngine;
using System.Collections;


//Return values of and validstates for behaviors
public enum Status
{
    INVALID,
    SUCCESS,
    FAILURE,
    RUNNING
}

public abstract class Behavior
{
    [SerializeField] private Status m_status;

    protected abstract Status Update(Blackboard bb);

    protected virtual void OnInitialize(Blackboard bb)
    {

    }

    protected virtual void OnTerminate(Status status, Blackboard bb)
    {

    }

    public Status Tick(Blackboard bb)
    {
        //If the status has not been initialized yet initalize it
        if (m_status == Status.INVALID)
        {
            this.OnInitialize(bb);
        }

        //Update the status
        m_status = Update(bb);

        //If the status is no longer running terminate it
        if (m_status != Status.RUNNING)
        {
            this.OnTerminate(m_status, bb);
        }

        return m_status;
    }
}
