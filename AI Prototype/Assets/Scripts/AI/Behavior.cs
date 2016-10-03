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

public class Behavior
{
    [SerializeField] private Status m_status;

    protected virtual Status Update()
    {
        return Status.INVALID;
    }

    protected virtual void OnInitialize()
    {

    }

    protected virtual void OnTerminate(Status status)
    {

    }

    public Status Tick()
    {
        //If the status has not been initialized yet initalize it
        if (m_status == Status.INVALID)
        {
            this.OnInitialize();
        }

        //Update the status
        m_status = Update();

        //If the status is no longer running terminate it
        if (m_status != Status.RUNNING)
        {
            this.OnTerminate(m_status);
        }

        return m_status;
    }
}
