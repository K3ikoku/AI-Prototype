using UnityEngine;
using System.Collections;

public class IsPlayerInSight : Behavior
{
    protected override Status Update(Blackboard bb)
    {
        //Debug.Log("Inside PlayerInSight");
        //Debug.Log("Checking if player is in sight");
        if (bb.Player == null)
        {
            return Status.FAILURE;
        }
        //Check if the player is within sight range
        if (bb.MaxSpotDistance >= Vector3.Distance(bb.Pos, bb.Player.transform.position))
        {
            bb.MoveSpeed = bb.StandardSpeed;
            return Status.SUCCESS;
        }
        return Status.FAILURE;
    }


}
