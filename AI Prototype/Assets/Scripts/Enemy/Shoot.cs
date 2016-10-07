using UnityEngine;
using System.Collections;

public class Shoot : MonoBehaviour
{
    [SerializeField] private GameObject m_bullet;
   

    private void Awake()
    {

    }

    public void Fire()
    {
        Vector3 m_shootLocation = transform.position + transform.forward * 1.0f;

        GameObject m_projectile = Instantiate(m_bullet);
        m_projectile.transform.position = m_shootLocation; 
        m_projectile.transform.rotation = transform.rotation;

        Rigidbody m_rb = m_projectile.GetComponent<Rigidbody>();
        m_rb.velocity = m_projectile.transform.forward * 5f;
    }
}
