using UnityEngine;
using System.Collections;
using Pathfinding;

public class Blackboard
{
    private Stats m_stats;

    public void SetStats(Stats stats)
    {
        m_stats = stats;
    }

    public Stats.TargetType CurrentTargetType
    {
        get { return m_stats.CurrentTargetType; }
        set { m_stats.CurrentTargetType = value; }
    }
    
    public int MaxHP
    {
        get { return m_stats.MaxHp; }
    }

    public int Health
        {
        get { return m_stats.Health; }
        set { m_stats.Health = value; }
    }

    public int Damage
    {
        get { return m_stats.Damage; }
        set { m_stats.Damage = value; }
    }
    
    public float MoveSpeed
    {
        get { return m_stats.MoveSpeed; }
        set { m_stats.MoveSpeed = value; }
    }

    public float RunSpeed
    {
        get { return m_stats.RunSpeed; }
    }

    public float StandardSpeed
    {
        get { return m_stats.StandardSpeed; }
    }

    public float WalkSpeed
    {
        get { return m_stats.WalkSpeed; }
    }

    public float MaxSpotDistance
    {
        get { return m_stats.MaxSpotDistance; }
        set { m_stats.MaxSpotDistance = value; }
    }

    public float MaxAttackDistance
    {
        get { return m_stats.MaxAttackDistance; }
        set { m_stats.MaxAttackDistance = value; }
    }

    public float AttackTimer
    {
        get { return m_stats.AttackTimer; }
        set { m_stats.AttackTimer = value; }
    }

    public float IdleTimer
    {
        get { return m_stats.IdleTimer; }
        set { m_stats.IdleTimer = value; }
    }

    public float IdleCD
    {
        get { return m_stats.IdleCD; }
        set { m_stats.IdleCD = value; }
    }

    public float FleeHealthThreshold
    {
        get { return m_stats.FleeHealthThreshold; }
    }

    public bool CanWalk
    {
        get { return m_stats.CanWalk; }
        set { m_stats.CanWalk = value; }
    }

    public bool CanIdle
    {
        get { return m_stats.CanIdle; }
        set { m_stats.CanIdle = value; }
    }

    public bool IsIdling
    {
        get { return m_stats.IsIdling; }
        set { m_stats.IsIdling = value; }
    }

    public Vector3 Target
    {
        get { return m_stats.Target; }
        set { m_stats.Target = value; }
    }

    public Vector3 Pos
    {
        get { return m_stats.Pos; }
    }

    public Quaternion Rotation
    {
        get { return m_stats.Rotation; }
        set { m_stats.Rotation = value; }
    }

    public Seeker Seeker
    {
        get { return m_stats.Seeker; }
    }
    
    public Path Path
    {
        get { return m_stats.Path; }
        set { m_stats.Path = value; }
    }

    public CharacterController CharController
    {
        get { return m_stats.CharController; }
    }

    public Shoot Shoot
    {
        get { return m_stats.Shoot; }
    }

    public GameObject Player
    {
        get { return m_stats.Player; }
    }

    public Rigidbody Rigidbody
    {
        get { return m_stats.Rigidbody; }
    }

}
