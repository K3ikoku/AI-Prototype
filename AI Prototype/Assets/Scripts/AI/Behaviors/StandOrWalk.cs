using UnityEngine;
using System.Collections;


public class StandOrWalk : Behavior
{
    protected override Status Update(Blackboard bb)
    {
        if (bb.CanWalk)
        {
            int i = Random.Range(0, 100);
            if (i >= 70)
            {
                bb.CanWalk = false;
                bb.MoveSpeed = bb.WalkSpeed;

                return Status.SUCCESS;
            }
        }
        return Status.FAILURE;

    }

}
