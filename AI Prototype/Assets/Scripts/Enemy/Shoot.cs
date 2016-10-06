using UnityEngine;
using System.Collections;

public class Shoot : MonoBehaviour
{
    [SerializeField] private Blackboard m_bb;
    [SerializeField] private GameObject m_bullet;

    private void Awake()
    {
        
    }

    public void Fire()
    {
        GameObject m_projectile = Instantiate(m_bullet) as GameObject;
        m_projectile.transform.position = transform.position;
        m_projectile.transform.rotation = transform.rotation;

        Rigidbody m_rb = m_projectile.GetComponent<Rigidbody>();
        m_rb.velocity = m_projectile.transform.forward * 50f;
    }
}
