using UnityEngine;
using System.Collections;

public class Soldier : Entity
{
    private BehaviorTree m_bt;
    private Blackboard m_bb;
    private Composite m_root;
    private Composite m_flee;
    private Composite m_attack;
    private Composite m_moveToPlayer;
    private Composite m_walk;
    private Composite m_idle;

    //TODO: Remove all the uneccesary nodes from the behavior tree
    protected override void Start()
    {
        base.Start();

        m_bb = new Blackboard();
        m_bb.SetStats(m_stats);
        m_bt = new BehaviorTree();
        m_root = new Selector();

        m_bt.SetRoot(m_root);

        m_flee =  (Composite)m_root.Add(new Sequence());
        m_flee.Add(new IsHpLow());
        m_flee.Add(new SetRandomLocation());
        m_flee.Add(new MoveToPosition());

        m_attack = (Composite)m_root.Add(new Sequence());
        m_attack.Add(new IsPlayerInRange());
        m_attack.Add(new Attack());

        m_moveToPlayer = (Composite)m_root.Add(new Sequence());
        m_moveToPlayer.Add(new IsPlayerInSight());
        m_moveToPlayer.Add(new TargetPlayer());
        m_moveToPlayer.Add(new MoveToPosition());

        m_walk = (Composite)m_root.Add(new Sequence());
        m_walk.Add(new StandOrWalk());
        m_walk.Add(new SetRandomLocation());
        m_walk.Add(new MoveToPosition());

        m_idle = (Composite)m_root.Add(new Sequence());
        m_idle.Add(new Idle());

    }

    protected override void Update()
    {
        base.Update();

        // UPPDATERA VARIABLER I BLACKBOARD OM NÖDVÄNDIGT


        m_bt.Update(m_bb);


    }

    public override void TakeDamage(int damage)
    {
        base.TakeDamage(damage);
    }

    protected override void Die()
    {
        base.Die();
        Debug.Log("Died the dead");
    }

    
}
