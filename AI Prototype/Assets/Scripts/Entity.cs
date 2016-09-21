using UnityEngine;
using System.Collections;

public class Entity : MonoBehaviour {

    [SerializeField] private int m_health;
    [SerializeField] private int speed;
    [SerializeField] private Transform m_target;

    public int Health
    {
        get { return m_health; }
        set { m_health = value; }

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
