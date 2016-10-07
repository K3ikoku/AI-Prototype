using UnityEngine;
using System.Collections;

public class Idle : Behavior
{
    protected override Status Update(Blackboard bb)
    {
        //Debug.Log("Idle");
        if(bb.IdleCD != 0)
        {
            bb.CanWalk = false;
            bb.IdleCD = Random.Range(5, 20);
        }

        bb.IdleTimer += Time.deltaTime;

        if(bb.IdleTimer >= bb.IdleCD)
        {
            bb.IdleTimer = 0;
            bb.CanWalk = true;

            return Status.SUCCESS;
        }

        return Status.RUNNING;
    }

}
