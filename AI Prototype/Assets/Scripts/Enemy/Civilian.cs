using UnityEngine;
using System.Collections;

public class Civilian : Entity
{
    //TODO: implement behavior tree 

    public override void TakeDamage(int m_damage)
    {
        base.TakeDamage(m_damage);
    }

    protected override void Die()
    {
        base.Die();
    }
}
