using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attacking : MonoBehaviour
{
    public GameObject Sword;

    private bool Abilityy = false;

    private Animator animator;

    private void Start()
    {
       Animator anim = GetComponent<Animator>();
    }

    /*void Update()
    {
        if (Input.GetMouseButton(0))
        {
            Debug.Log("Pressed left click.");

            animator.SetBool("Abilityy", true);


            //Sword.GetComponent<Animator>().Play("AbilityT");

            //itAnim();
        }

        else
        {
            animator.SetBool("Abilityy", false);
        }
    }*/
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


    void Update()
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
    }
}
