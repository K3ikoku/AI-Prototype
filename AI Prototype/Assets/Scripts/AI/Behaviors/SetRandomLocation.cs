using UnityEngine;
using System.Collections;
using Pathfinding;

public class SetRandomLocation : Behavior
{
    private bool m_isPathing = false;
    private bool m_foundPath = false;
    private Status m_status;
    
    private Path m_path;


    protected override Status Update(Blackboard bb)
    {
        
        if(bb.Target != null)
        {
            
            if (!m_isPathing)
            {
                m_status = Status.RUNNING;
                bb.MoveSpeed = bb.RunSpeed;
                
                //Set the target location to a random place inside the game area
                bb.Target.position = new Vector3((Random.Range(-32, 32)), 0, (Random.Range(-12, 12)));

                bb.Seeker.StartPath(bb.Pos, bb.Target.position, OnPathComplete);

                m_isPathing = true;
            }

        }
        else
        {
            m_status = Status.FAILURE;
        }


        if(m_foundPath)
        {
            m_foundPath = false;
            bb.Path = m_path;
            m_path = null;
        }


        return m_status;
    }

    private void OnPathComplete(Path p)
    {
        m_isPathing = false;
        if(!p.error)
        {
            m_foundPath = true;
            m_path = p;
            m_status = Status.SUCCESS;
        }
        else
        {
            m_status = Status.FAILURE;
        }
    }
}
