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

    private void Start()
    {
        m_Animator = gameObject.GetComponent<Animator>();
        Ability = false;
    }

    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            Debug.Log("Pressed left click.");

            Ability = true;

            //animator.SetBool("Abilityy", true);
            //Sword.GetComponent<Animator>().Play("Abilityy");
            //itAnim();
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

    }
}
