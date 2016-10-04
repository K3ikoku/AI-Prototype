using UnityEngine;
using System.Collections;

public class Blackboard
{
    private Stats m_stats;


    public void SetStats(Stats stats)
    {
        m_stats = stats;
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

    public float WalkSpeed
    {
        get { return m_stats.WalkSpeed; }
    }

    public Transform Target
    {
        get { return m_stats.Target; }
        set { m_stats.Target = value; }
    }

    public Vector3 TargetPos
    {
        get { return m_stats.TargetPos; }
        set { m_stats.TargetPos = value; }
    }

    public Vector3 Pos
    {
        get { return m_stats.Pos; }
    }

    public Seeker Seeker
    {
        get { return m_stats.Seeker; }
    }   

}
