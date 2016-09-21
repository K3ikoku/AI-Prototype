using UnityEngine;
using System.Collections;

public class AIController : MonoBehaviour
{
    public TreeNode root;
    
    void Update()
    {
        root.Tick();
    }
}
