using UnityEngine;
using System.Collections;

public class Attack : Behavior
{
    protected override Status Update(Blackboard bb)
    {
        //Check if the player is existing
        if (bb.Player != null)
        {
            //See if the player still has health and attack if it does
            if (bb.Player.GetComponent<Blackboard>().Health > 0)
            {   
                //Check if ready to attack 
                if (bb.AttackTimer >= 2.5)
                {
                    bb.AttackTimer = 0;
                    
                    bb.Rotation.SetLookRotation(bb.Target.position);
                    bb.Shoot.Fire();
                }

                else
                {
                    bb.AttackTimer += Time.deltaTime;
                }
                return Status.RUNNING;
            }
            else
            {
                return Status.FAILURE;
            }
        }
        
        return Status.FAILURE;
    }
}
