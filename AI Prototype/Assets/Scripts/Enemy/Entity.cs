using UnityEngine;
using System.Collections;

public class Entity : MonoBehaviour
{
    private Blackboard m_bBoard;
    private Stats m_stats;
	// Use this for initialization
	protected virtual void Start ()
    {
        m_bBoard = gameObject.GetComponent<Blackboard>();
        m_stats = gameObject.GetComponent<Stats>();

        m_bBoard.SetStats(m_stats);
	}
	
	// Update is called once per frame
	protected virtual void Update ()
    {
	}


    //Called whenever character takes damage
    public virtual void TakeDamage(int damage)
    {
        m_bBoard.Health -= damage;

        if (m_bBoard.Health <= 0)
            Die();
    }

    protected virtual void Die()
    {
        DestroyObject(gameObject);
    }
}
