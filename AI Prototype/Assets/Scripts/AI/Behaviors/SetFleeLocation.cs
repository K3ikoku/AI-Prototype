using UnityEngine;
using System.Collections;

public class SetFleeLocation : Behavior
{
    private GameObject m_ground = GameObject.FindGameObjectWithTag("Ground");

    protected override Status Update(Blackboard bb)
    {
        //Set the target location to a random place inside the game area
        bb.TargetPos = new Vector3((Random.Range(-32, 32)), 0, (Random.Range(-12, 12)));

        if(bb.TargetPos != null)
        {
            bb.MoveSpeed = bb.RunSpeed;
            return Status.SUCCESS;
        }


        return Status.FAILURE;
    }
}
