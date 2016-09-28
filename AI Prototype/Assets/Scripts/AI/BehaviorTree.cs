using UnityEngine;
using System.Collections;
using System.Collections.Generic;

class BehaviorTree : MonoBehaviour
{
    //Timer that decides how often the tree is going to update
    [SerializeField] private float m_cooldown;

    //Roof of the tree
    [SerializeField] private Behavior m_tree;

    [SerializeField] private float m_timer;

    public void SetRoot(Behavior root)
    {
        m_tree = root;
    }

    void Update()
    {
        m_timer -= Time.deltaTime;

        if(m_timer <= 0)
        {
            m_timer = m_cooldown;

            if(m_tree != null)
            {
                m_tree.Tick();
            }
        }
    }
}

