using UnityEngine;
using System.Collections;

public class Player : Entity
{
    [SerializeField] private int m_health;

    public int Health
    {
        get { return m_health; }
        set { m_health = value; }
    }

    public override void TakeDamage(int damage)
    {
        base.TakeDamage(damage);
    }

    protected override void Die()
    {
        base.Die();

        Application.Quit();
    }



}
