﻿using UnityEngine;
using System.Collections;

public class Entity : MonoBehaviour
{
    protected Stats m_stats;

    
	// Use this for initialization
	protected virtual void Start ()
    {
        m_stats = gameObject.GetComponent<Stats>();
	}
	
	// Update is called once per frame
	protected virtual void Update ()
    {
	}


    //Called whenever character takes damage
    public virtual void TakeDamage(int damage)
    {
        m_stats.Health -= damage;

        if (m_stats.Health <= 0)
            Die();
    }

    protected virtual void Die()
    {
        DestroyObject(gameObject);
    }
}
