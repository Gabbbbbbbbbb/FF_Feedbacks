using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attacking : MonoBehaviour
{

    public GameObject Sword;

    //private bool Abilityy = false;

    private Animator m_Animator;
    bool Ability;

    private void Start()
    {
       //Animator anim = GetComponent<Animator>();

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
            //animator.SetBool("Abilityy", false);

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

    /*private void HitAnim()
    {
        if (Att)
        {
            animator.SetBool("Att", true);
        }

        else
        {
            animator.SetBool("Att", false);
        }*/


    /*void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("Eurêka");
            //fire = true;
            animator.SetBool("Abilityy", true);
        }

        else
        {
            animator.SetBool("Abilityy", false);
        }
    }*/
}
