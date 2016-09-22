using UnityEngine;
using System.Collections;
using System;


public enum Status
{
    INVALID, 
    SUCCESFUL,
    FAILURE, 
    RUNNING
}
public class Node : MonoBehaviour
{

    public virtual Task Create(Node node)
    {
        return 0;
    }

    public virtual void Destroy(Task task)
    {

    }




}

public class Task : MonoBehaviour
{
    protected Node m_parentNode;


    public virtual Status Update()
    {
        return 0;
    }

    public void OnInit()
    {

    }

    public void OnTerminate(Status status)
    {

    }
}

public class Behavior
{
    protected Task m_task = null;
    protected Node m_node = null;
    protected Status m_status;


    public void Setup (Node node)
    {
        TearDown();

        m_node = node;
        m_task = node.Create(node);
    }

    public void TearDown()
    {
        if(m_task == null)
        {
            return;
        }

        m_node.Destroy(m_task);
        m_task = null;
    }

    public Status Tick()
    {
        if(m_status == Status.INVALID)
        {
            m_task.OnInit();
        }

        m_status = m_task.Update();

        if(m_status != Status.RUNNING)
        {
            m_task.OnTerminate(m_status);
        }

        return m_status;
    }

}