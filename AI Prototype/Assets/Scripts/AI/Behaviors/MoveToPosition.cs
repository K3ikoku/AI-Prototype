using UnityEngine;
using System.Collections;
using Pathfinding;

public class MoveToPosition : Behavior
{
    protected override Status Update(Blackboard bb)
    {
        if (bb.Path != null)
        {
            //Check if the character is close enough to the next waypoint and remove if so
            if (Vector3.Distance(bb.Pos, bb.Path.vectorPath[0]) < 3)
            {
                bb.Path.vectorPath.RemoveAt(0);
            }

            
            //Check if reached the destination and remove the path
            if (0 == bb.Path.vectorPath.Count)
            {
                bb.Path = null;
                return Status.SUCCESS;
            }

            //Move the character
            else
            {
                Vector3 m_dir = (bb.Path.vectorPath[0] - bb.Pos).normalized;
                m_dir *= bb.MoveSpeed * Time.deltaTime;
                bb.CharController.SimpleMove(m_dir);
            }
        }


        else
        {
            return Status.FAILURE;
        }

        return Status.RUNNING;
    }
}

