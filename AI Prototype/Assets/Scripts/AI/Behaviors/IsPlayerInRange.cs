using UnityEngine;
using System.Collections;

public class IsPlayerInRange : Behavior
{
    protected override Status Update(Blackboard bb)
    {
        //Debug.Log("Checking if player is in range");
        if(bb.Player == null)
        {
            return Status.FAILURE;
        }
        if (bb.MaxAttackDistance >= Vector3.Distance(bb.Pos, bb.Player.transform.position))
        {
            bb.Target = bb.Player.transform.position;
            return Status.SUCCESS;
        }
        return Status.FAILURE;
    }
}
