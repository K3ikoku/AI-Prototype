using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Composite : Behavior
{
    protected List<Behavior> m_children;

    protected void Add(Behavior behavior)
    {
        m_children.Add(behavior);
    }

    protected void Remove(Behavior behavior)
    {
        m_children.Remove(behavior);
    }
}
