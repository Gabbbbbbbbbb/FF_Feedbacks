using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attacking : MonoBehaviour
{

    public GameObject Sword;

    private Animator m_Animator;
    bool Ability;
    public Transform Spawn;
    public GameObject projectile;
    public float fireRate = 2000f;
    private float nextFire = 0.0f;

    public float timeRemaining = 1;
    public bool timerIsRunning = false;

    public float animeSlash = 1f;
    public bool animeTimer = false;

    public bool CanShoot = true;

    public GameObject Sound;

    private void Start()
    {
        m_Animator = gameObject.GetComponent<Animator>();
        Ability = false;
    }

    //Two timers in progress
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            //Debug.Log("Pressed left click.");
            Ability = true;
            timerIsRunning = true;
            animeTimer = true;

            if (Time.time > nextFire && timeRemaining == 1 && animeSlash == 0)
            {
                nextFire = Time.time + fireRate;
                animeSlash = 1f;
            }
        }

        else
        {
            Ability = false;
        }

        if (Ability == true)
        {
            m_Animator.SetBool("Abilityy", true);
        }
        if (Ability == false)
        {
            m_Animator.SetBool("Abilityy", false);
        }

        if (timerIsRunning)
        {
            if (timeRemaining > 0)
            {
                timeRemaining -= Time.deltaTime;
            }

            else
            {
                CanShoot = true;
                timeRemaining = 0;
                timerIsRunning = false;
                timeRemaining = 1;
            }
        }

        if (animeTimer)
        {
            if (animeSlash > 0)
            {
                animeSlash -= Time.deltaTime;
            }

            else
            {
                animeSlash = 0;
                animeTimer = false;
            }
        }

        if(animeTimer == true)
        {
            Sound.SetActive(true);
        }

        if (animeTimer == false)
        {
            Sound.SetActive(false);
        }
    }

    public void Slash()
    {
        //Debug.Log("Test");
        Instantiate(projectile, Spawn.position, Spawn.rotation);
    }
}
