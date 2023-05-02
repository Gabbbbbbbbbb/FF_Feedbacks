using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocksHit : MonoBehaviour
{

    [SerializeField] private GameManagerUI GameManagerUI;

    void OnTriggerEnter(Collider collision)
    {
        if (collision.CompareTag("Projectile"))
        {
            //Debug.Log("The ground");
            GameManagerUI.Rock();
        }
    }
}
