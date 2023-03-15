using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attacking : MonoBehaviour
{
    public Animator _animator;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            Debug.Log("Pressed left click.");
            _animator.SetBool("Attack", true);
        }

        else
        {
            _animator.SetBool("Attack", false);
        }
    }
}
