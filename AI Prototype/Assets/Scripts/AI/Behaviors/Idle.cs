using UnityEngine;
using System.Collections;

public class Idle : Behavior
{
    protected override Status Update(Blackboard bb)
    {
        //Debug.Log("Inside idle");
        //Debug.Log("Idle");
        if (!bb.IsIdling && bb.CanIdle)
        {
            bb.CanWalk = false;
            bb.IsIdling = true;
            bb.IdleCD = Random.Range(5, 20);
        }

        bb.IdleTimer += Time.deltaTime;

        if(bb.IdleTimer >= bb.IdleCD)
        {
            bb.CanWalk = true;
            bb.IsIdling = false;
            bb.IdleTimer = 0;
            bb.CurrentTargetType = Stats.TargetType.UNDEFINED;

            return Status.SUCCESS;

        }

        return Status.RUNNING;
    }

}
