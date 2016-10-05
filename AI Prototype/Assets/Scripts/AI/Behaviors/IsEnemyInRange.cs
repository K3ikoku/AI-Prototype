using UnityEngine;
using System.Collections;

public class IsEnemyInRange : Behavior
{
    protected override Status Update(Blackboard bb)
    {
        if (bb.MinAttackDistance >= Vector3.Distance(bb.Pos, bb.Target.position))
        {
            return Status.SUCCESS;
        }
        return Status.FAILURE;
    }
}
