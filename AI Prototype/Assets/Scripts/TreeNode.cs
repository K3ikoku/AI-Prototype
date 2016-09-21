using UnityEngine;
using System.Collections;
using System;

public abstract class TreeNode : MonoBehaviour
{
    public abstract void Init(Hashtable m_data);
    public abstract NodeStatus Tick();
}

public enum NodeStatus
{
    SUCCESS,
    FAILURE,
    RUNNING
}

public abstract class Decorator : TreeNode
{
    public TreeNode m_child;

    public override void Init(Hashtable m_data)
    {
        m_child.Init(m_data);
    }
}

public abstract class Compositor : TreeNode
{
    public TreeNode[] m_children;

    public override void Init(Hashtable m_data)
    {
        foreach (TreeNode child in m_children)
        {
            child.Init(m_data);
        }
    }
}
