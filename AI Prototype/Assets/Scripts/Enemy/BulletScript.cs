using UnityEngine;
using System.Collections;

public class BulletScript : Entity
{
    [SerializeField] private int m_damage = 5;

    // Use this for initialization
    protected override void Start()
    {
        base.Start();
    }

    // Update is called once per frame
    protected override void Update()
    {
        base.Update();
    }

    protected override void Die()
    {
        base.Die();

        Debug.Log("Bullet died");
    }

    void OnCollisionEnter(Collision collision)
    {
        foreach (ContactPoint contact in collision.contacts)
        {
            Debug.DrawRay(contact.point, contact.normal, Color.white);

            if (collision.transform.tag == "Player")
            {
                collision.transform.GetComponent<Entity>().TakeDamage(m_damage);
            }

            Die();
        }
    }
}
