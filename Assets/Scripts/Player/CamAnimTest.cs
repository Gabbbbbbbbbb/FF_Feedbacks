using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamAnimTest : MonoBehaviour
{
    private Animator m_Animator;

    //bool Movement;

    void Start()
    {
        m_Animator = gameObject.GetComponent<Animator>();
        //Movement = false;
    }

    void Update()
    {
        /*if (Input.GetMouseButton(0))
        {
            //Debug.Log("Click");
            Movement = true;
        }*/

        /*else
        {
            Movement = false;
        }

        if (Movement == true)
        {
            m_Animator.SetBool("Move", true);
        }

        if (Movement == false)
        {
            m_Animator.SetBool("Move", false);
        }*/
    }

    public void AnimTrigger()
    {
        m_Animator.SetTrigger("MOVE");
    }
}
