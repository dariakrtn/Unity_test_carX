using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button_event : MonoBehaviour
{
    public GameObject menu;
    public GameObject manual;
    public GameObject spawner;

    public GameObject m_projectilePrefabCannon;
    public Transform m_shootPointCannon;

    public float m_shootInterval = 100f;
    public GameObject m_projectilePrefabCrystal;
    public Transform m_shootPointCrystal;

    public float fire = 0.5f;
    private float next = 0.0f;

    private float m_lastShotTime = -0.5f;



    private void Update()
    {
        if (menu.activeSelf == true)
        {
            spawner.SetActive(false);
        }
        else
            spawner.SetActive(true);
    }

    public void Attack_cannon()
    {
        if (m_projectilePrefabCannon == null || m_shootPointCannon == null)
            return;

        Instantiate(m_projectilePrefabCannon, m_shootPointCannon.position, m_shootPointCannon.rotation);

    }


// кнопка которй стреляет башня с кристалом 
    public void Attack_crystal()
    {
        if ((m_projectilePrefabCrystal == null || m_shootPointCrystal == null) && Time.time > next)
            return;
        next = Time.time + fire;

        foreach (var monster in FindObjectsOfType<Monster>() )
        {
          

            if (m_lastShotTime + m_shootInterval > Time.time)
                continue;

            // shot
            var projectile = Instantiate(m_projectilePrefabCrystal, m_shootPointCrystal.position, m_shootPointCrystal.rotation) as GameObject;
            var projectileBeh = projectile.GetComponent<GuidedProjectile>();
            projectileBeh.m_target = monster.gameObject;

            m_lastShotTime = Time.time;
        }

    }

    public void Open_menu()
    {
        menu.SetActive(true);
    }

    public void Play_game()
    {
        menu.SetActive(false);
    }

    public void Open_manual()
    {
        
        manual.SetActive(true);
    }

    public void Close_manual()
    {
        manual.SetActive(false);

    }

    public void Exit_game()
    {
        Application.Quit();
    }
}
