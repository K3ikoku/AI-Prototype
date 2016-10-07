using UnityEngine;
using System.Collections;

public class Attack : Behavior
{
    protected override Status Update(Blackboard bb)
    {
        //Debug.Log("Attacking player");
        //Check if the player is existing
        if (bb.Player != null)
        {
            //See if the player still has health and attack if it does
            if (0 < bb.Player.GetComponent<Player>().Health)
            {   
                //Check if ready to attack 
                if (bb.AttackTimer >= 2.5)
                {
                    bb.AttackTimer = 0;
                    
                    bb.Rotation.SetLookRotation(bb.Target);
                    bb.Shoot.Fire();
                    return Status.SUCCESS;
                }

                else
                {
                    bb.AttackTimer += Time.deltaTime;
                    return Status.SUCCESS;
                }
            }
            else
            {
                return Status.FAILURE;
            }
        }
        
        return Status.FAILURE;
    }
}
