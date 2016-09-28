using UnityEngine;
using System.Collections;

public class Selector : Composite
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
        Status s = m_currentChild.Tick();
        Debug.Log(i);

        //Keep going until a child behavior is running
        while (true)
        {
            //If the child succeeds or keeps running do the same
            if (s != Status.FAILURE)
            {
                return s;
            }


            i++;
            Debug.Log(i);


            //Hit the end of the array
            if (m_currentChild == m_children[m_children.Count - 1])
            {
                return Status.FAILURE;
            }
        }
    }
}
