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
        //Debug.Log("Setting new random location");

        if (bb.CurrentTargetType != Stats.TargetType.RANDOM)
        {
            if (!m_isPathing && !m_foundPath)
            {
                m_status = Status.RUNNING;

                bb.CurrentTargetType = Stats.TargetType.RANDOM;

                //Set the target location to a random place inside the game area
                bb.Target = new Vector3((Random.Range(-32, 32)), 0, (Random.Range(-12, 12)));

                bb.Seeker.StartPath(bb.Pos, bb.Target, OnPathComplete);

                m_isPathing = true;
            }

            if (m_foundPath)
            {
                m_foundPath = false;
                bb.Path = m_path;
                m_path = null;
            }

        }

        else
        {
            m_status = Status.SUCCESS;
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
