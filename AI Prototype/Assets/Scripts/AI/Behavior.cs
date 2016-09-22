using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Behaviour : MonoBehaviour
{
    public enum Status
    {
        INVALID,
        SUCCESS,
        FAILURE,
        RUNNING
    }

    [SerializeField] private Status m_status;


    // Update is called once per frame
    protected virtual Status Update()
    {

        return 0;
    }

    protected virtual void OnInit ()
    {
	
	}

    protected virtual void OnTerminate(Status status)
    {

    }

    public Status Tick()
    {
        if (m_status == Status.INVALID)
        {
            OnInit();
        }

        m_status = Update();

        if(m_status != Status.RUNNING)
        {
            OnTerminate(m_status);
        }
        
        return m_status;
    }
}

public class Composite : Behaviour
{
    protected List<Behaviour> m_children;
    
}

public class Sequence : Composite
{
    protected override void OnInit()
    {
        
    }

    protected override Status Update()
    {

        //Check all children until one says it's running
        foreach(Behaviour m_currentChild in m_children)
        {
            Status s = m_currentChild.Tick();


            //if the child fails or keeps running do the same
            if(s != Status.SUCCESS)
            {
                return s;
            }


            //Return success at end of the list
            if(m_currentChild == m_children[m_children.Count - 1])
            {
                return Status.SUCCESS;
            }
        }

        Debug.Log("Unexpected loop exit");
        return Status.INVALID;

        //while(true)
        //{
        //    Status s = (m_currentChild).Tick();

        //    if(s != Status.SUCCESS)
        //    {
        //        return s;
        //    }

        //    if(m_currentChild++ == m_children.end())
        //    {
        //        return Status.SUCCESS;
        //    }
        //}

        //return Status.INVALID;
    }
     
}

public class Selector : Composite
{
    protected override void OnInit()
    {
        base.OnInit();
    }

    protected override Status Update()
    {
        foreach(Behaviour m_current in m_children)
        {
            Status s = m_current.Tick();

            if (s != Status.FAILURE)
            {
                return s;
            }

            if(m_current == m_children[m_children.Count - 1])
            {
                return Status.FAILURE;
            }

        }

        Debug.Log("Unexpected loop exit");
        return Status.INVALID;
    }
}
