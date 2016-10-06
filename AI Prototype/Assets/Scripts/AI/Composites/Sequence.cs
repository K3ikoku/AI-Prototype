using UnityEngine;
using System.Collections;


public class Sequence : Composite
{
    protected Behavior m_currentChild;
    private int i = 0;

    protected new virtual void OnInitialize(Blackboard bb)
    {
        m_currentChild = m_children[i];
    }

    protected new virtual Status Update(Blackboard bb)
    {

        //Keep going through the list until a child behavior is running
        while (true)
        {
            Status s = m_currentChild.Tick(bb);
            if (s != Status.SUCCESS)
            {
                Debug.Log("Checking children of sequence" + i);
                return s;
            }

            i++;

            //Hit the end of the list
            if (m_children[i] == m_children[m_children.Count - 1])
            {
                return Status.SUCCESS;
            }
        }
    }
}
