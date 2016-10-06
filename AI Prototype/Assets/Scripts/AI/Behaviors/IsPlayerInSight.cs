using UnityEngine;
using System.Collections;

public class IsPlayerInSight : Behavior
{
    protected override Status Update(Blackboard bb)
    {
        //Check if the player is within sight range
        if (bb.MaxSpotDistance >= Vector3.Distance(bb.Pos, bb.Player.transform.position))
        {
            bb.MoveSpeed = bb.StandardSpeed;
            return Status.SUCCESS;
        }
        return Status.FAILURE;
    }


}
