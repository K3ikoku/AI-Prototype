using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public abstract class Composite : Behavior
{
    protected List<Behavior> m_children = new List<Behavior>();

    public Behavior Add(Behavior behavior)
    {
        m_children.Add(behavior);
        return behavior;
    }

    public void Remove(Behavior behavior)
    {
        m_children.Remove(behavior);
    }
}
