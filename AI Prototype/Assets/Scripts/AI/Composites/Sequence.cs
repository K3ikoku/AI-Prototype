using UnityEngine;
using System.Collections;


public class Sequence : Composite
{
    protected Behavior m_currentChild;
    private int i = 0;

    protected override void OnInitialize(Blackboard bb)
    {
        m_currentChild = m_children[i];
    }

    protected override Status Update(Blackboard bb)
    {
        //Keep going through the list until a child behavior is running
        while (i < m_children.Count)
        {
            Status s = m_children[i].Tick(bb);
            if (s == Status.FAILURE)
            {
                i = 0;
                return s;
            }
            if (s == Status.RUNNING)
            {
                return s;
            }

            i++;
        }

        i = 0;
        return Status.SUCCESS;
    }
}
