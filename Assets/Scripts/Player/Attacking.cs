using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attacking : MonoBehaviour
{
    public GameObject Sword;

    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            Debug.Log("Pressed left click.");
            
            Sword.GetComponent<Animator>().Play("AbilityT");
        }
    }
}
