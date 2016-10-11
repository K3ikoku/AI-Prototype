using UnityEngine;
using System.Collections;
using Pathfinding;

public class MoveToPosition : Behavior
{
    protected override Status Update(Blackboard bb)
    {
        //Debug.Log("Checking in move to position");
        if (bb.Path != null)
        {
            //Check if reached the destination and remove the path
            if (0 == bb.Path.vectorPath.Count)
            {
                bb.Path = null;
                bb.CurrentTargetType = Stats.TargetType.UNDEFINED;
                return Status.SUCCESS;
            }

            //Debug.Log("Inside Moveto " + bb.CurrentTargetType);
            //Check if the character is close enough to the next waypoint and remove if so
            if (Vector3.Distance(bb.Pos, bb.Path.vectorPath[0]) < 3)
            {
                bb.Path.vectorPath.RemoveAt(0);
                return Status.SUCCESS;
            }

            //Move the character
            Vector3 m_dir = (bb.Path.vectorPath[0] - bb.Pos).normalized;
            m_dir.y = 0;
            m_dir *= bb.MoveSpeed * Time.deltaTime;
            Rigidbody rb =  bb.Rigidbody;
            rb.MovePosition(bb.Pos + m_dir);
            bb.Rotation = Quaternion.LookRotation(m_dir);
            return Status.RUNNING;
            
        }


        else
        {
            return Status.FAILURE;
        }
    }
}

