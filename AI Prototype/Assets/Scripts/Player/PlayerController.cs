﻿using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float m_laserTimer;
    [SerializeField] private float m_laserCD;
    [SerializeField] private int m_damage;
    private GameObject m_objHit;

	// Use this for initialization
	void Start ()
    {
        m_laserTimer = 0f;
	}
	
	// Update is called once per frame
	void Update ()
    {
        //Check if left mouse button is pressed
        if (m_laserTimer <= 0f)
        {
            if (Input.GetMouseButton(0))
            {
                m_laserTimer = m_laserCD;
                RaycastHit m_hit;
                Ray m_ray = Camera.main.ScreenPointToRay(Input.mousePosition);

                
                Physics.Raycast(m_ray, out m_hit);


                m_objHit = m_hit.transform.gameObject;
                //TODO: Implement Aoe effect.

                Debug.DrawLine(Camera.main.transform.position, m_hit.point, Color.red);
                Debug.Log("Shot fired at: " + m_hit.point);


                if(m_objHit.tag == "Enemy")
                {
                    m_objHit.GetComponent<Entity>().TakeDamage(m_damage);
                }
            }
        }
        else
        {
            m_laserTimer -= (1 * Time.deltaTime);
            Debug.Log("Laser timer: " + m_laserTimer);

        }

        if (m_laserTimer <= 0)
            m_laserTimer = 0f;

	}
}
