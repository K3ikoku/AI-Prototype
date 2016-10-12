using UnityEngine;
using System.Collections;


public class StandOrWalk : Behavior
{
    protected override Status Update(Blackboard bb)
    {
        //Debug.Log("Checking if walk or stand");

        if (bb.CurrentTargetType != Stats.TargetType.RANDOM)
        {
            if (bb.CanWalk)
            {
                //Debug.Log("Inside standorwalk");
                int i = Random.Range(0, 100);
                //Debug.Log(i);
                //int i = 100;
                if (i >= 50)
                {
                    bb.CanWalk = false;
                    bb.CanIdle = false;
                    bb.MoveSpeed = bb.WalkSpeed;

                    return Status.SUCCESS;
                }
                else
                {
                    bb.CanIdle = true;
                    return Status.FAILURE;
                }
            }

            else
            {
                return Status.FAILURE;
            }
        }

        else
        {
            return Status.SUCCESS;
        }
    }

}
