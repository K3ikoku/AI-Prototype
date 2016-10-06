using System;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using System.Text;

class IsHpLow : Behavior
{
    
    protected override Status Update(Blackboard bb)
    {
        Debug.Log("Checking IsHpLow");   
        if (bb.Health <= (bb.MaxHP * bb.FleeHealthThreshold))
        {
            bb.MoveSpeed = bb.RunSpeed;
            return Status.SUCCESS;
        }
        return Status.FAILURE;
    }
}
