using UnityEngine;
using System.Collections;
using Pathfinding;

public class MoveToPosition : Behavior
{
    private Seeker m_seeker;

    protected override Status Update(Blackboard bb)
    {
        if(bb.Target.position == null)
        {
            return Status.FAILURE;
        }

        bb.Seeker.StartPath(bb.Pos, bb.TargetPos);
        //TODO: Implement the full move function

    }

    private void Move()
}
