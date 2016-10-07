using UnityEngine;
using System.Collections;

public class Selector : Composite
{

    private int i = 0;

    protected override Status Update(Blackboard bb)
    {
        while(i < m_children.Count)
        {
            Status s = m_children[i].Tick(bb);
            if(s == Status.SUCCESS)
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
        return Status.FAILURE;
    }
}
