using UnityEngine;
using System.Collections;

public class Soldier : Entity
{
    [SerializeField] private int m_health;
    [SerializeField] private int m_speed;
    [SerializeField] private Transform m_target;

    private Composite m_bt;
    private Blackboard m_bb;

    protected override void Start()
    {
        base.Start();

        m_bb = new Blackboard();

        m_bt = new Selector();

        var sequence =  (Composite)m_bt.Add(new Sequence());
        sequence.Add(new Behavior());
        sequence.Add(new Behavior());
        sequence.Add(new Behavior());
        
        sequence = (Composite)m_bt.Add(new Sequence());
        sequence.Add(new Behavior());
    }

    protected override void Update()
    {
        base.Update();

        // UPPDATERA VARIABLER I BLACKBOARD OM NÖDVÄNDIGT
        

        m_bt.Tick(m_bb);
    }

    public override void TakeDamage(int m_damage)
    {
        base.TakeDamage(m_damage);
    }

    protected override void Die()
    {
        base.Die();
    }

    
}
