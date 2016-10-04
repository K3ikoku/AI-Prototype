using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class IsHpLow : Behavior
{

    protected override Status Update(Blackboard bb)
    {
        if (bb.Health <= (bb.MaxHP * 0.2))
        {
            return Status.SUCCESS;
        }
        return Status.FAILURE;
    }
}
