using UnityEngine;
using System.Collections;

public class IsPlayerInRange : Behavior
{
    protected override Status Update(Blackboard bb)
    {
        if (bb.MaxAttackDistance >= Vector3.Distance(bb.Pos, bb.Player.transform.position))
        {
            return Status.SUCCESS;
        }
        return Status.FAILURE;
    }
}
