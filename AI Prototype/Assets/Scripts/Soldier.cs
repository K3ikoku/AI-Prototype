using UnityEngine;
using System.Collections;

public class Soldier : Entity
{
    [SerializeField] private int m_health;
    [SerializeField] private int m_speed;
    [SerializeField] private Transform m_target;

    public override void TakeDamage(int m_damage)
    {
        base.TakeDamage(m_damage);
    }

    protected override void Die()
    {
        base.Die();
    }
}
