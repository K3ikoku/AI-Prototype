using UnityEngine;
using System.Collections;

public class Sequence : Composite
{
    [SerializeField]
    protected Behavior m_currentChild;
    [SerializeField]
    private int i = 0;

    protected new virtual void OnInitialize()
    {
        m_currentChild = m_children[i];
    }

    protected new virtual Status Update()
    {

        //Keep going through the list until a child behavior is running
        while (true)
        {
            Status s = m_currentChild.Tick();
            Debug.Log(i);
            if (s != Status.SUCCESS)
            {
                return s;
            }

            i++;
            Debug.Log(i);

            //Hit the end of the list
            if (m_children[i] == m_children[m_children.Count - 1])
            {
                return Status.SUCCESS;
            }
        }
    }
}
