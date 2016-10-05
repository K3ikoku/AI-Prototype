using UnityEngine;
using System.Collections;

public class Soldier : Entity
{
    [SerializeField] private int m_health;
    [SerializeField] private int m_speed;
    [SerializeField] private Transform m_target;

    private BehaviorTree m_bt;
    private Blackboard m_bb;
    private Composite m_root;
    private Composite m_flee;
    private Composite m_attack;

    protected override void Start()
    {
        base.Start();

        m_bb = new Blackboard();
        m_bt = new BehaviorTree();
        m_root = new Selector();

        m_bt.SetRoot(m_root);

        m_flee =  (Composite)m_root.Add(new Sequence());
        m_flee.Add(new IsHpLow());
        m_flee.Add(new SetRandomLocation());
        m_flee.Add(new MoveToPosition());

        m_attack = (Composite)m_root.Add(new Sequence());
        m_attack.Add(new IsEnemyInRange());

        //sequence = (Composite)m_bt.Add(new Sequence());
        //sequence.Add(new Behavior());
    }

    protected override void Update()
    {
        base.Update();

        // UPPDATERA VARIABLER I BLACKBOARD OM NÖDVÄNDIGT


        m_bt.Update(m_bb);
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
