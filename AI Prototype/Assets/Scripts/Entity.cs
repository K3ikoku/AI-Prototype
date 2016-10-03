using UnityEngine;
using System.Collections;

public class Entity : MonoBehaviour {

    [SerializeField] private int m_health;
    [SerializeField] private float m_speed;
    [SerializeField] private Transform m_target;
    [SerializeField] private Transform m_pos;

    public int Health
    {
        get { return m_health; }
        set { m_health = value; }
    }

    public float Speed
    {
        get { return m_speed; }
        set { m_speed = value; } 
    }

    public Transform Target
    {
        get { return m_target; }
        set { m_target = value; }
    }

    public Transform Pos
    {
        get { return gameObject.transform; }
    }


	// Use this for initialization
	void Start ()
    {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}


    //Called whenever character takes damage
    public virtual void TakeDamage(int m_damage)
    {
        this.Health -= m_damage;

        if (this.Health <= 0)
            Die();
    }

    protected virtual void Die()
    {
        DestroyObject(gameObject);
    }
}
