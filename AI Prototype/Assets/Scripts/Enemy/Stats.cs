using UnityEngine;
using System.Collections;
using Pathfinding;

public class Stats : MonoBehaviour
{

    [SerializeField] private int m_maxHP;
    [SerializeField] private int m_currentHealth;
    [SerializeField] private int m_damage;

    [SerializeField] private float m_moveSpeed;
    [SerializeField] private float m_runSpeed;
    [SerializeField] private float m_walkSpeed;
    [SerializeField] private float m_minSpotDistance;
    [SerializeField] private float m_minAttackDistance;

    [SerializeField] private Transform m_target;
    [SerializeField] private Vector3 m_pos;

    [SerializeField] private Seeker m_seeker;
    [SerializeField] private Path m_path;
    [SerializeField] private CharacterController m_controller;


    void Awake()
    {
        Health = MaxHp;
        m_seeker = GetComponent<Seeker>();
        if(Seeker == null)
        {
            Debug.Log("Missing seeker");
        }

        m_controller = GetComponent<CharacterController>();
        if(CharController == null)
        {
            Debug.Log("Missing character controller");
        }
    }

    public int MaxHp
    {
        get { return m_maxHP; }
        set { m_maxHP = value; }
    }

    public int Health
    {
        get { return m_currentHealth; }
        set { m_currentHealth = value; }
    }

    public int Damage
    {
        get { return m_damage; }
        set { m_damage = value; }
    }

    public float MoveSpeed
    {
        get { return m_moveSpeed; }
        set { m_moveSpeed = value; }
    }

    public float RunSpeed
    {
        get { return m_runSpeed; }
    }

    public float WalkSpeed
    {
        get { return m_walkSpeed; }
    }

    public Transform Target
    {
        get { return m_target; }
        set { m_target = value; }
    }

    public Vector3 Pos
    {
        get { return transform.position; }
    }

    public float MinSpotDistance
    {
        get { return m_minSpotDistance; }
        set { m_minSpotDistance = value; }
    }
    
    public float MinAttackDistance
    {
        get { return m_minAttackDistance; }
        set { m_minAttackDistance = value; }
    }

    public Seeker Seeker
    {
        get { return m_seeker; }
    }

    public Path Path
    {
        get { return m_path; }
        set { m_path = value; }
    }
    
    public CharacterController CharController
    {
        get { return m_controller; }
    }
}
